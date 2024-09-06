using OfficeOpenXml;
using System.IO;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using TradersChamp.Data;
using System.Diagnostics;

// ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

namespace TradersChamp.View.Admin.Report
{

    public partial class CarReport : Form
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDBContext _dbContext;



        public CarReport()
        {
            InitializeComponent();
            this._serviceProvider = Program.ServiceProvider;
            this._dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
        }

        private void btnGenerateCarReport_Click(object sender, EventArgs e)
        {
            var cars = _dbContext.Car.ToList();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Create a new Excel package
            using (var package = new ExcelPackage())
            {
                // Add a new worksheet to the Excel file
                var worksheet = package.Workbook.Worksheets.Add("Car Report");

                // Add headers
                worksheet.Cells[1, 1].Value = "Brand";
                worksheet.Cells[1, 2].Value = "Model";
                worksheet.Cells[1, 3].Value = "Year";
                worksheet.Cells[1, 4].Value = "Body Style";
                worksheet.Cells[1, 5].Value = "Engine";
                worksheet.Cells[1, 6].Value = "Transmission";
                worksheet.Cells[1, 7].Value = "Drivetrain";
                worksheet.Cells[1, 8].Value = "Fuel Type";
                worksheet.Cells[1, 9].Value = "Mileage";
                worksheet.Cells[1, 10].Value = "VIN";
                worksheet.Cells[1, 11].Value = "Color";
                worksheet.Cells[1, 12].Value = "Interior Color";
                worksheet.Cells[1, 13].Value = "Num Of Doors";
                worksheet.Cells[1, 14].Value = "Seating Capacity";
                worksheet.Cells[1, 15].Value = "Price";
                worksheet.Cells[1, 16].Value = "Status";

                // Populate the sheet with car data
                for (int i = 0; i < cars.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = cars[i].Brand;
                    worksheet.Cells[i + 2, 2].Value = cars[i].Model;
                    worksheet.Cells[i + 2, 3].Value = cars[i].Year;
                    worksheet.Cells[i + 2, 4].Value = cars[i].BodyStyle;
                    worksheet.Cells[i + 2, 5].Value = cars[i].Engine;
                    worksheet.Cells[i + 2, 6].Value = cars[i].Transmission;
                    worksheet.Cells[i + 2, 7].Value = cars[i].Drivetrain;
                    worksheet.Cells[i + 2, 8].Value = cars[i].FuelType;
                    worksheet.Cells[i + 2, 9].Value = cars[i].Mileage;
                    worksheet.Cells[i + 2, 10].Value = cars[i].VIN;
                    worksheet.Cells[i + 2, 11].Value = cars[i].Color;
                    worksheet.Cells[i + 2, 12].Value = cars[i].InteriorColor;
                    worksheet.Cells[i + 2, 13].Value = cars[i].NumOfDoors;
                    worksheet.Cells[i + 2, 14].Value = cars[i].SeatingCapacity;
                    worksheet.Cells[i + 2, 15].Value = cars[i].Price;
                    worksheet.Cells[i + 2, 16].Value = cars[i].Status;


                }

                string directory = Directory.GetCurrentDirectory();
                string fileName = "CarReport.xlsx";
                string filePath = Path.Combine(directory, fileName);
                int fileIndex = 1;

                while (File.Exists(filePath))
                {
                    // If the file exists, generate a new file name with an incrementing number
                    string tempFileName = Path.GetFileNameWithoutExtension(fileName) + $"({fileIndex})" + Path.GetExtension(fileName);
                    filePath = Path.Combine(directory, tempFileName);
                    fileIndex++;
                }

                // Save the file to disk
                File.WriteAllBytes(filePath, package.GetAsByteArray());


                // Open the file
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(processStartInfo);

            }

        }
    }
}

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using iText.Kernel.Geom;
using TradersChamp.Data;
using TradersChamp.Model;
using TradersChamp.Util;
using Microsoft.Extensions.DependencyInjection;
using TradersChamp.Service;
using System;

namespace TradersChamp.View.Customer.Order
{
    public partial class CarOrderView : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ApplicationDBContext _dbContext;
        private readonly MailService _mailService;
        private readonly Utility _utility;

        private Panel pnlMain;
        private Car Car;
        private Users User;

        public CarOrderView(Panel pnlMain, Car car, Users user)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            this.Car = car;
            this.User = user;
            UpdateLabels();
            UpdateTotal(txtQty.Text, txtPrice.Text);

            _serviceProvider = Program.ServiceProvider;
            _dbContext = _serviceProvider.GetRequiredService<ApplicationDBContext>();
            _mailService = _serviceProvider.GetRequiredService<MailService>();
            _utility = _serviceProvider.GetRequiredService<Utility>();


        }

        private void UpdateTotal(string Qty, string Price)
        {
            if (int.TryParse(Qty, out int qty) && double.TryParse(Price, out double price))
            {
                txtTotal.Text = (qty * price).ToString();
            }

        }

        private void UpdateLabels()
        {
            lblBrandName.Text = Car.Brand;
            lblModelName.Text = Car.Model;
            lblYear.Text = Car.Year;
            lblBodyStyle.Text = Car.BodyStyle;
            lblEngine.Text = Car.Engine;
            lblTransmission.Text = Car.Transmission;
            lblDrivetrain.Text = Car.Drivetrain;
            lblFuelType.Text = Car.FuelType;
            lblMileage.Text = Car.Mileage;
            lblMileage.Text = Car.Mileage;
            lblVIN.Text = Car.VIN;
            lblColor.Text = Car.Color;
            lblInteriorColor.Text = Car.InteriorColor;
            lblDoorsCount.Text = Car.NumOfDoors;
            lblSeatingCapacity.Text = Car.SeatingCapacity;
            lblPrice.Text = Convert.ToString(Car.Price);
            txtPrice.Text = Convert.ToString(Car.Price);
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {

            var Qty = Convert.ToInt32(txtQty.Text);
            var Total = Convert.ToDouble(txtTotal.Text);

            var order = new CarOrder
            {
                CarId = Car.Id,
                UserId = User.Id,
                Quantity = Qty,
                Price = Total,
                PaymentMethod = "CASH",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now

            };

            _dbContext.CarOrder.Add(order);
            _dbContext.SaveChanges();

            var receiptPath = CreatePdfReceipt(Qty, Total);
            SendEmailNotification(receiptPath);

            MessageBox.Show("Your Car order is completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            _utility.LoadForm(new CarView(pnlMain, User), pnlMain);


        }

        private string CreatePdfReceipt(int Qty, double Total)
        {
            var fileName = $"CarOrder_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            var filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            using (var writer = new PdfWriter(filePath))
            {
                var pdf = new PdfDocument(writer);
                var document = new Document(pdf, PageSize.A4);
                document.SetMargins(20, 20, 20, 20);

                document.Add(new Paragraph("Car Order Receipt")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20)
                    .SetBold());

                document.Add(new Paragraph($"Date: {DateTime.Now:dd/MM/yyyy}"));
                document.Add(new Paragraph($"Order ID: {Guid.NewGuid()}"));
                document.Add(new Paragraph($"Brand: {Car.Brand}"));
                document.Add(new Paragraph($"Model: {Car.Model}"));
                document.Add(new Paragraph($"Year: {Car.Year}"));
                document.Add(new Paragraph($"Price per Unit: {Car.Price:C}"));
                document.Add(new Paragraph($"Quantity: {Qty}"));
                document.Add(new Paragraph($"Total Price: {Total:C}"));
                document.Add(new Paragraph($"Payment Method: CASH"));

                document.Close();
            }

            return filePath;
        }

        private void SendEmailNotification(string receiptPath)
        {
            var subject = "Car Order Confirmation";
            var body = """
                Dear Customer,

                Your Car order has been successfully placed. Please find the attached receipt for your order.

                Thank you for shopping with us.

                Best regards,
                ABC Traders Team
                """

            _mailService.SendEmailWithAttachmentAsync(User.Email, subject, body, receiptPath);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal(txtQty.Text, txtPrice.Text);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal(txtQty.Text, txtPrice.Text);
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace TradersChamp.Model
{
    internal class Car
    {
        [Key]
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string BodyStyle { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Drivetrain { get; set; }
        public string FuelType { get; set; }
        public string Mileage { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
        public string InteriorColor { get; set; }
        public string NumOfDoors { get; set; }
        public string SeatingCapacity { get; set; }

    }
}

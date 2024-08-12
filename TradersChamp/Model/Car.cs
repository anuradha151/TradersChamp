using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradersChamp.Model
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public double Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}

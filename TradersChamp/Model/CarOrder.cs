using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradersChamp.Model
{
    public class CarOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid CarId { get; set; }
        public Guid UserId { get; set; }      
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string PaymentMethod { get; set; }   
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("CarId")]
        public Car Car { get; set; }
        [ForeignKey("UserId")]
        public Users User { get; set; }

    }
}

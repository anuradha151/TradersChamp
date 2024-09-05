using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradersChamp.Dto
{
    internal class CarPartCartItemDto
    {
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}

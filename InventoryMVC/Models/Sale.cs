using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryMVC.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double PricePerUnit { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
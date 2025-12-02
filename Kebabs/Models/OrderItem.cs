using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Models
{
    public class OrderItem
    {
        public string FoodName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal => UnitPrice * Quantity;
    }
}

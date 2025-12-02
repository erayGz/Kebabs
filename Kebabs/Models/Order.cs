using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RestaurantId { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public string Status { get; set; } = "Pending";
    }
}

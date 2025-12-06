using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kebabs.Models
{
    public class Order
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public int CustomerId { get; set; }
        [Browsable(false)]
        public int RestaurantId { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public string CustomerAddress { get; set; } = "";
        public string Status { get; set; } = "Pending";
    }
}

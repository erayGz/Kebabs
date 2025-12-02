using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CourierId { get; set; }

        public string RestaurantAddress { get; set; } = "";
        public string CustomerAddress { get; set; } = "";

        public string Status { get; set; } = "Assigned";
    }

}

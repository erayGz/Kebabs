using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kebabs.Models
{
    public class Delivery
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public int OrderId { get; set; }
        [Browsable(false)]
        public int CourierId { get; set; }

        public string RestaurantAddress { get; set; } = "";
        public string CustomerAddress { get; set; } = "";

        public string Status { get; set; } = "Assigned";
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kebabs.Models
{
    public class Food
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public int RestaurantId { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}

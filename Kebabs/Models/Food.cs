using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Models
{
    public class Food
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}

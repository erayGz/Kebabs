using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kebabs.Models
{
    public class Restaurant
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";

    }
}

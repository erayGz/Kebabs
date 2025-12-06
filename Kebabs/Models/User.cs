using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kebabs.Models
{
    public class User
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

    }
}

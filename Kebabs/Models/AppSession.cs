using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Models
{
    public class AppSession
    {
        public static User? CurrentUser {  get; set; }
    }
}

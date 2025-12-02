using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Data
{
    public static class InMemoryDatabase
    {
        public static List<User> Users = new();
        public static List<Restaurant> Restaurants = new();
        public static List<Food> Foods = new();
        public static List<Order> Orders = new();
        public static List<Delivery> Deliveries = new();
    }
}

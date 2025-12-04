using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs
{
    public class InMemoryDatabase
    {
        public static List<User> Users = new();
        public static List<Restaurant> Restaurants = new();
        public static List<Food> Foods = new();
        public static List<Order> Orders = new();
        public static List<Delivery> Deliveries = new();


        //Demo Data (for login)
        static InMemoryDatabase()
        {
            Users.Add(new User { Id = 1, Username = "customer1", Password = "123", Role = "Customer" });
            Users.Add(new User { Id = 1, Username = "rest1", Password = "123", Role = "Restaurant" });
            Users.Add(new User { Id = 1, Username = "courier1", Password = "123", Role = "Courier" });

            Restaurants.Add(new Restaurant { Id = 1, Name = "Turkebab", Address = "Azenes iela 5" });
            Foods.Add(new Food { Id = 1, RestaurantId = 1, Name = "Ankara Kebab", Price = 8.50m });
            Foods.Add(new Food { Id = 2, RestaurantId = 1, Name = "Durum", Price = 6.00m });

        }
    }
}

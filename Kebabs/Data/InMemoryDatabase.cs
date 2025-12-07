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
            Users.Add(new User { Id = 1, Username = "customer1", Password = "123", Role = "Customer", Address = "Customer Street 1" });
            Users.Add(new User { Id = 2, Username = "rest1", Password = "123", Role = "Restaurant",Address = "Azenes iela 5" });
            Users.Add(new User { Id = 3, Username = "courier1", Password = "123", Role = "Courier" , Address = "Courier Base" });
            Users.Add(new User { Id = 100, Username = "admin1", Password = "123", Role = "Admin", Address = "Back Office" });

            Restaurants.Add(new Restaurant { Id = 2, Name = "Turkebab", Address = "Azenes iela 5" });
            Foods.Add(new Food { Id = 1, RestaurantId = 2, Name = "Ankara Kebab", Price = 8.50m });
            Foods.Add(new Food { Id = 2, RestaurantId = 2, Name = "Durum", Price = 6.00m });

        }
    }
}

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

        static InMemoryDatabase()
        {
            Users.Add(new User { Id = 1, Username = "customer1", Password = "123", Role = "Customer", Address = "Customer Street 1" });
            Users.Add(new User { Id = 2, Username = "rest1", Password = "123", Role = "Restaurant",Address = "Azenes iela 5" });
            Users.Add(new User { Id = 3, Username = "courier1", Password = "123", Role = "Courier" , Address = "Courier Base" });
            Users.Add(new User { Id = 100, Username = "admin1", Password = "123", Role = "Admin", Address = "Back Office" });

            Restaurants.Add(new Restaurant { Id = 2, Name = "Turkebab", Address = "Azenes iela 5" });
            Foods.Add(new Food { Id = 1, RestaurantId = 2, Name = "Ankara Kebab", Price = 8.50m });
            Foods.Add(new Food { Id = 2, RestaurantId = 2, Name = "Durum", Price = 6.00m });

            Restaurants.Add(new Restaurant { Id = 21, Name = "La Bella Pizza & Kebab", Address = "Dzirciema iela 84a" });
            Foods.Add(new Food { Id = 1, RestaurantId = 21, Name = "KEBAB BOX", Price = 7.50m });
            Foods.Add(new Food { Id = 2, RestaurantId = 21, Name = "Lahmacun", Price = 8.00m });

            Restaurants.Add(new Restaurant { Id = 22, Name = "Turkish restaurant \"IZO\"", Address = " Bauskas iela 79-1/2" });
            Foods.Add(new Food { Id = 1, RestaurantId = 22, Name = "Turkish pide", Price = 13m });
            Foods.Add(new Food { Id = 2, RestaurantId = 22, Name = "Baklava", Price = 5.00m });

            Restaurants.Add(new Restaurant { Id = 23, Name = "Reigys Kebabs", Address = "Skolas iela 12" });
            Foods.Add(new Food { Id = 1, RestaurantId = 23, Name = "Shawarma", Price = 9.00m });
            Foods.Add(new Food { Id = 2, RestaurantId = 23, Name = "Durum", Price = 5.30m });

        }
    }
}

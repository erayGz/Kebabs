using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Services
{
    public class RestaurantService
    {
        public List<Restaurant> GetRestaurants()
        {
            return InMemoryDatabase.Restaurants;
        }
    }
}

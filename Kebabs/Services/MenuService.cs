using Kebabs.Data;
using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Services
{
    public class MenuService
    {
        public List<Food> GetMenu(int restaurantid)
        {
            return InMemoryDatabase.Foods.Where(
              f => f.RestaurantId == restaurantid).ToList();
        }
    }
}

using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kebabs.Services
{
    public class OrderService
    {
        public Order CreateOrder(int customerId, int restaurantId, List<OrderItem> items)
        {
            var order = new Order
            {
                Id = InMemoryDatabase.Orders.Count + 1,
                CustomerId = customerId,
                RestaurantId = restaurantId,

                // Copy of List
                Items = items
                    .Select(i => new OrderItem
                    {
                        FoodName = i.FoodName,
                        UnitPrice = i.UnitPrice,
                        Quantity = i.Quantity
                    })
                    .ToList(),

                Status = "Pending"
            };
            InMemoryDatabase.Orders.Add(order);
            
            InMemoryDatabase.Deliveries.Add(new Delivery
            {
                Id = InMemoryDatabase.Deliveries.Count + 1,
                OrderId = order.Id,
                CourierId = 3, // courier1 kullanıcısının Id'si (User listende ne ise onu yaz)
                RestaurantAddress = "Kebab House, Main Street",
                CustomerAddress = "Some Customer Address",
                Status = "Assigned"
            });
            return order;
        }

        public List<Order> GetORdersByRestaurant(int restaurantId)
        {
            return InMemoryDatabase.Orders.Where(
                o => o.RestaurantId == restaurantId).ToList();
        }

        public void UpdateStatus(int orderId, string newStatus)
        {
            var order = InMemoryDatabase.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                order.Status = newStatus;
            }
        }
    }
}

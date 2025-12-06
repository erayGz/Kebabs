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
            return order;
            var newOrder = new Order
            {
                Id = InMemoryDatabase.Orders.Count + 1,
                CustomerId = customerId,
                RestaurantId = restaurantId,
                Items = items,
                Status = "Pending"
            };
            InMemoryDatabase.Orders.Add(newOrder);

            InMemoryDatabase.Deliveries.Add(new Delivery
            {
                Id = InMemoryDatabase.Deliveries.Count + 1,
                OrderId = newOrder.Id,
                CourierId = 3,
                RestaurantAddress = "Restaurant Address Example",
                CustomerAddress = "Customer Address Example",
                Status = "Assigned"
            });

            return newOrder;
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

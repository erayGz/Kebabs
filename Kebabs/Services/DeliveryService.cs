using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Services
{
    public class DeliveryService
    {
        public List<Delivery> GetAssignmentDeliveries(int courierId)
        {
            return InMemoryDatabase.Deliveries.Where(
             d=> d.CourierId == courierId).ToList();
        }
        public void UpdateStatus(int deliveryId, string status)
        {
            var delivery = InMemoryDatabase.Deliveries.FirstOrDefault(d => d.Id == deliveryId)  ;

            if (delivery == null)
                return;

            delivery.Status = status;

            // if delivery successed update order status
            if (status == "Delivered")
            {
                var order = InMemoryDatabase.Orders
                    .FirstOrDefault(o => o.Id == delivery.OrderId);

                if (order != null)
                    order.Status = "Delivered";
            }

        }
    }
}

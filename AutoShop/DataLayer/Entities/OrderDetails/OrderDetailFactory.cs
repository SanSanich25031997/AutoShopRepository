using System;

namespace DataLayer.Entities.OrderDetails
{
    public class OrderDetailFactory : IOrderDetailFactory
    {
        public OrderDetail Create(string orderId, string carId, int price)
        {
            return new OrderDetail
            {
                Id = Guid.NewGuid().ToString(),
                OrderId = orderId,
                CarId = carId,
                Price = price
            };
        }
    }
}

namespace DataLayer.Entities.OrderDetails
{
    public class OrderDetailFactory : IOrderDetailFactory
    {
        public OrderDetail Create(int id, int orderId, int carId, int price)
        {
            return new OrderDetail
            {
                Id = id,
                OrderId = orderId,
                CarId = carId,
                Price = price
            };
        }
    }
}

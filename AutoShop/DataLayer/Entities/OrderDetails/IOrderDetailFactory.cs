namespace DataLayer.Entities.OrderDetails
{
    public interface IOrderDetailFactory
    {
        OrderDetail Create(string orderId, string carId, int price);
    }
}

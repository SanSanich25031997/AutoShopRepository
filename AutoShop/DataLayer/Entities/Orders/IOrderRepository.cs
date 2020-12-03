namespace DataLayer.Entities.Orders
{
    public interface IOrderRepository
    {
        void CreateOrder(string id, string name, string lastName, string address, string phone, string email);
    }
}

namespace DataLayer.Entities.Orders
{
    public interface IOrderRepository
    {
        void CreateOrder(int id, string name, string lastName, string address, string phone, string email);
    }
}

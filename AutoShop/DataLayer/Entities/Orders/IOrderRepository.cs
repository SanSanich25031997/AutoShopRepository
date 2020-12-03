namespace DataLayer.Entities.Orders
{
    public interface IOrderRepository
    {
        void CreateOrder(string firstName, string lastName, string address, string phone, string email);
    }
}

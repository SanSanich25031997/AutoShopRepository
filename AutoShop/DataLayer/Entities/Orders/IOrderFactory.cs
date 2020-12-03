namespace DataLayer.Entities.Orders
{
    public interface IOrderFactory
    {
        Order Create(string firstName, string lastName, string address, string phone, string email);
    }
}

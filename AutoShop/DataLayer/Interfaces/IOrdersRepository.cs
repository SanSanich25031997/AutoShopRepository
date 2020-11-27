using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface IOrdersRepository
    {
        void CreateOrder(int id, string name, string lastName, string address, string phone, string email);
    }
}

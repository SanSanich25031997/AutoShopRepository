using System;

namespace DataLayer.Entities.Orders
{
    public class OrderFactory : IOrderFactory
    {
        public Order Create(string firstName, string lastName, string address, string phone, string email)
        {
            return new Order
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Phone = phone,
                Email = email,
                OrderDate = DateTime.UtcNow
            };
        }
    }
}

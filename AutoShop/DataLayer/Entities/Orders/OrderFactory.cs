using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Orders
{
    public class OrderFactory : IOrderFactory
    {
        public Order Create(int id, string firstName, string lastName, string address, string phone, string email)
        {
            return new Order
            {
                Id = id,
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

using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Orders
{
    public interface IOrderFactory
    {
        Order Create(int id, string firstName, string lastName, string address, string phone, string email);
    }
}

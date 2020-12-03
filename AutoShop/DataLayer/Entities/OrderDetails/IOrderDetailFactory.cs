using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.OrderDetails
{
    public interface IOrderDetailFactory
    {
        OrderDetail Create(string orderId, string carId, int price);
    }
}

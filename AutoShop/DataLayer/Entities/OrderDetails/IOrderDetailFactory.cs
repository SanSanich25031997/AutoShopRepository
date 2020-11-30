using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.OrderDetails
{
    public interface IOrderDetailFactory
    {
        OrderDetail Create(int id, int orderId, int carId, int price);
    }
}

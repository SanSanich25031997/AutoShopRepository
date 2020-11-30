using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities.Cars;
using DataLayer.Entities.Orders;

namespace DataLayer.Entities.OrderDetails
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int Price { get; set; }
        public Car Car { get; set; }
        public Order Order { get; set; }
    }
}

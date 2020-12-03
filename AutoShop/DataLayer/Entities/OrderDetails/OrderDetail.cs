using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using DataLayer.Entities.Cars;
using DataLayer.Entities.Orders;

namespace DataLayer.Entities.OrderDetails
{
    public class OrderDetail
    {
        [Key]
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string CarId { get; set; }
        public int Price { get; set; }
        public Car Car { get; set; }
        public Order Order { get; set; }
    }
}

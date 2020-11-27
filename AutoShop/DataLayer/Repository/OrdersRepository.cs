using DataLayer.Interfaces;
using DataLayer.Entities;
using System;

namespace DataLayer.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;
        private readonly AutoShopCart autoShopCart;

        public OrdersRepository(AutoShopDbContext autoShopDbContext, AutoShopCart autoShopCart)
        {
            this.autoShopDbContext = autoShopDbContext;
            this.autoShopCart = autoShopCart;
        }

        public void CreateOrder(int id, string name, string lastName, string address, string phone, string email)
        {
            Order order = new Order
            {
                Id = id,
                Name = name,
                LastName = lastName,
                Address = address,
                Phone = phone,
                Email = email,
                OrderDate = DateTime.UtcNow
            };
            autoShopDbContext.Order.Add(order);
            autoShopDbContext.SaveChanges();

            var items = autoShopCart.ListAutoShopItems;

            foreach (var element in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = element.Car.Id,
                    OrderId = order.Id,
                    Price = element.Car.Price
                };

                autoShopDbContext.OrderDetail.Add(orderDetail);
            }

            autoShopDbContext.SaveChanges();
        }
    }
}

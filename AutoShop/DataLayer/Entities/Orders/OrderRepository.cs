using System;
using DataLayer.Entities.AutoShopCarts;
using DataLayer.Entities.OrderDetails;

namespace DataLayer.Entities.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;
        private readonly AutoShopCart autoShopCart;

        public OrderRepository(AutoShopDbContext autoShopDbContext, AutoShopCart autoShopCart)
        {
            this.autoShopDbContext = autoShopDbContext;
            this.autoShopCart = autoShopCart;
        }

        public void CreateOrder(string name, string lastName, string address, string phone, string email)
        {
            Order order = new Order
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = name,
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

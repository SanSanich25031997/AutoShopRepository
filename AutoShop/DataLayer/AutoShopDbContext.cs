﻿using Microsoft.EntityFrameworkCore;
using DataLayer.Entities.Cars;
using DataLayer.Entities.Categories;
using DataLayer.Entities.AutoShopCartItems;
using DataLayer.Entities.Orders;
using DataLayer.Entities.OrderDetails;

namespace DataLayer
{
    public class AutoShopDbContext : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<AutoShopCartItem> AutoShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        public AutoShopDbContext(DbContextOptions<AutoShopDbContext> options) : base(options) { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Entities.Cars
{
    public class CarFactory : ICarFactory
    {
        public Car Create(string name, string description, string image, int price, bool IsFavorite, bool isAvailable, string categoryId)
        {
            return new Car()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Description = description,
                Image = image,
                Price = price,
                IsFavorite = IsFavorite,
                IsAvailable = isAvailable,
                CategoryId = categoryId
            };
        }
    }
}

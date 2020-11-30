using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Cars
{
    public class CarFactory : ICarFactory
    {
        public Car Create(int id, string name, string description, string image, int price, bool IsFavorite, bool isAvailable, int categoryId)
        {
            return new Car()
            {
                Id = id,
                Name = name,
                Description = description,
                Image = image,
                Price = price,
                IsFavorite = IsFavorite,
                IsAvailable = isAvailable
            };
        }
    }
}

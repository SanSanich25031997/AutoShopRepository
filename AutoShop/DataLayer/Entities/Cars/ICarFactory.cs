using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Cars
{
    public interface ICarFactory
    {
        Car Create(int id, string name, string description, string image, int price, bool isFavorite, bool isAvailable, int categoryId);
    }
}

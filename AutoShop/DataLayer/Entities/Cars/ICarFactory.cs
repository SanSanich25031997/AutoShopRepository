﻿namespace DataLayer.Entities.Cars
{
    public interface ICarFactory
    {
        Car Create(string name, string description, string image, int price, bool isFavorite, bool isAvailable, string categoryId);
    }
}

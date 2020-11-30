using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataLayer.Entities.Categories;

namespace DataLayer.Entities.Cars
{
    public class CarMock
    {
        private readonly ICategoryRepository CategoryCars = new CategoryMock();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla Model s",
                        Description = "Очень популярные электромобили",
                        Image = "/images/Tesla.jpg",
                        Price = 3900000,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category = CategoryCars.AllCategories.First(),
                    },
                    new Car
                    {
                        Name = "BMW X5",
                        Description = "Один из самых популярных автомобилей мира.",
                        Image = "/images/BMW.jpg",
                        Price = 5150000,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category = CategoryCars.AllCategories.Last(),
                    },
                    new Car
                    {
                        Name = "Mercedes-Benz",
                        Description = "Одна из самых популярных машин мира.",
                        Image = "/images/Mercedes.jpg",
                        Price = 2230000,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category = CategoryCars.AllCategories.Last(),
                    },
                    new Car
                    {
                        Name = "LADA Granta",
                        Description = "Очень популярный автомобиль в России.",
                        Image = "/images/LADA.jpg",
                        Price = 483900,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category = CategoryCars.AllCategories.Last(),
                    },
                    new Car
                    {
                        Name = "Toyota Prius",
                        Description = "Довольно известный автомобиль",
                        Image = "/images/Toyota.jpg",
                        Price = 2322000,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category = CategoryCars.AllCategories.First(),
                    }
                };
            }
        }

        public IEnumerable<Car> GetFavoriteCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            return null;
        }
    }
}

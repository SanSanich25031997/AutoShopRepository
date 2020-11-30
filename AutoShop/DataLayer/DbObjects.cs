using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities.Cars;
using DataLayer.Entities.Categories;

namespace DataLayer
{
    public class DbObjects
    {
        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Name = "Электромобили", 
                            Description = "Современный вид транспорта"},
                        new Category { Name = "Топливные автомобили", 
                            Description = "Автомобиль с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category element in list)
                    {
                        category.Add(element.Name, element);
                    }
                }

                return category;
            }
        }

        public static void Initial(AutoShopDbContext context)
        {
            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Car.Any())
            {
                context.AddRange(
                    new Car
                    {
                        Name = "Tesla",
                        Description = "Очень популярные электромобили",
                        Image = "/images/Tesla.jpg",
                        Price = 450000,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category = Categories["Электромобили"],
                    },
                    new Car
                    {
                        Name = "BMW X5",
                        Description = "Один из самых популярных автомобилей мира.",
                        Image = "/images/BMW.jpg",
                        Price = 5150000,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category = Categories["Топливные автомобили"],
                    },
                    new Car
                    {
                        Name = "Mercedes-Benz",
                        Description = "Одна из самых популярных машин мира.",
                        Image = "/images/Mercedes.jpg",
                        Price = 2230000,
                        IsFavorite = true,
                        IsAvailable = true,
                        Category = Categories["Топливные автомобили"],
                    },
                    new Car
                    {
                        Name = "LADA Granta",
                        Description = "Очень популярный автомобиль в России.",
                        Image = "/images/LADA.jpg",
                        Price = 483900,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category = Categories["Топливные автомобили"],
                    },
                    new Car
                    {
                        Name = "Toyota Prius",
                        Description = "Довольно известный автомобиль",
                        Image = "/images/Toyota.jpg",
                        Price = 2322000,
                        IsFavorite = false,
                        IsAvailable = true,
                        Category = Categories["Электромобили"],
                    }
                );
            }

            context.SaveChanges();
        }
    }
}

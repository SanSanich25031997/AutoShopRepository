using System.Collections.Generic;
using DataLayer.Interfaces;
using DataLayer.Entities;


namespace DataLayer.Mocks
{
    public class MockCategory : ICarCategoriesRepository
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Электромобили", Description = "Современный вид транспорта"},
                    new Category { CategoryName = "Топливные автомобили", Description = "Автомобиль с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}

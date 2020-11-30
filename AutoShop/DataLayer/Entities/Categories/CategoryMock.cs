using System.Collections.Generic;

namespace DataLayer.Entities.Categories
{
    public class CategoryMock : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Электромобили", Description = "Современный вид транспорта"},
                    new Category { Name = "Топливные автомобили", Description = "Автомобиль с двигателем внутреннего сгорания" }
                };
            }
        }
    }
}

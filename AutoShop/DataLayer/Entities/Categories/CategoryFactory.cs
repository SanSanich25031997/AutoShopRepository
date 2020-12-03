using System;

namespace DataLayer.Entities.Categories
{
    public class CategoryFactory : ICategoryFactory
    {
        public Category Create(string name, string description)
        {
            return new Category()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Description = description
            };
        }
    }
}

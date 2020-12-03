using System.Collections.Generic;

namespace DataLayer.Entities.Categories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

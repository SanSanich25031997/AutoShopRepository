using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface ICarCategoriesRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

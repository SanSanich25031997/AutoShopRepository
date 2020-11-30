using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Categories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

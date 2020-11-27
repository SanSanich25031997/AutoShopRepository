using DataLayer.Interfaces;
using DataLayer.Entities;
using System.Collections.Generic;

namespace DataLayer.Repository
{
    public class CategoriesRepository : ICarCategoriesRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;

        public CategoriesRepository(AutoShopDbContext autoShopDbContext)
        {
            this.autoShopDbContext = autoShopDbContext;
        }

        public IEnumerable<Category> AllCategories => autoShopDbContext.Category;
    }
}

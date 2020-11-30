using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;

        public CategoryRepository(AutoShopDbContext autoShopDbContext)
        {
            this.autoShopDbContext = autoShopDbContext;
        }

        public IEnumerable<Category> AllCategories => autoShopDbContext.Category;
    }
}

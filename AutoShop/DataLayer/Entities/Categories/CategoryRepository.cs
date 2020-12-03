using System.Collections.Generic;

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

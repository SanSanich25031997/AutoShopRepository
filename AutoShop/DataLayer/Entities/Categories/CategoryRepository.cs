using Microsoft.EntityFrameworkCore;

namespace DataLayer.Entities.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;

        public CategoryRepository(AutoShopDbContext autoShopDbContext)
        {
            this.autoShopDbContext = autoShopDbContext;
        }

        public DbSet<Category> AllCategories => autoShopDbContext.Category;
    }
}

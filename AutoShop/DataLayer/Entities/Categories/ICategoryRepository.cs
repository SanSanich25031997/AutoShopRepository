using Microsoft.EntityFrameworkCore;

namespace DataLayer.Entities.Categories
{
    public interface ICategoryRepository
    {
        DbSet<Category> AllCategories { get; }
    }
}

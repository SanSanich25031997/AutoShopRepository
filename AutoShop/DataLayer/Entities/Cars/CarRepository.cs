using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using DataLayer.Entities.Categories;

namespace DataLayer.Entities.Cars
{
    public class CarRepository : ICarRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;

        public CarRepository(AutoShopDbContext autoShopDbContext)
        {
            this.autoShopDbContext = autoShopDbContext;
        }

        public IIncludableQueryable<Car, Category> Cars => autoShopDbContext.Car.Include(c => c.Category);

        public IIncludableQueryable<Car, Category> GetFavoriteCars => autoShopDbContext.Car.Where(p => p.IsFavorite)
            .Include(c => c.Category);

        public Car GetObjectCar(string carId) => autoShopDbContext.Car.FirstOrDefault(p => p.Id.Equals(carId));

        public IQueryable<Car> FindCarsByCategory(string category)
        {
            IQueryable<Car> carsList;
            if (string.IsNullOrEmpty(category))
            {
                carsList = autoShopDbContext.Car.OrderBy(c => c.Id);
            }
            else
            {
                carsList = autoShopDbContext.Car.Where(c => c.Category.Name
                .Equals(category)).OrderBy(c => c.Id);
            }

            return carsList;
        }
    }
}

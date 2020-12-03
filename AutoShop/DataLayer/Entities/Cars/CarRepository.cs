using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Entities.Cars
{
    public class CarRepository : ICarRepository
    {
        private readonly AutoShopDbContext autoShopDbContext;

        public CarRepository(AutoShopDbContext autoShopDbContext)
        {
            this.autoShopDbContext = autoShopDbContext;
        }

        public IEnumerable<Car> Cars => autoShopDbContext.Car.Include(c => c.Category).ToList();

        public IEnumerable<Car> GetFavoriteCars => autoShopDbContext.Car.Where(p => p.IsFavorite)
            .Include(c => c.Category).ToList();

        public Car GetObjectCar(string carId) => autoShopDbContext.Car.FirstOrDefault(p => p.Id.Equals(carId));

        public IEnumerable<Car> FindCarsByCategory(string category)
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

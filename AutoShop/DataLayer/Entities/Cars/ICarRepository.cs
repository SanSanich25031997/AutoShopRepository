using System.Linq;
using Microsoft.EntityFrameworkCore.Query;
using DataLayer.Entities.Categories;

namespace DataLayer.Entities.Cars
{
    public interface ICarRepository
    {
        IIncludableQueryable<Car, Category> Cars { get; }
        IIncludableQueryable<Car, Category> GetFavoriteCars { get; }
        Car GetObjectCar(string carId);
        IQueryable<Car> FindCarsByCategory(string category);
    }
}

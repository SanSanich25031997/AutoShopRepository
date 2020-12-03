using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;
using DataLayer.Entities.Categories;

namespace DataLayer.Entities.Cars
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavoriteCars { get; }
        Car GetObjectCar(string carId);
        IEnumerable<Car> FindCarsByCategory(string category);
    }
}

using System.Collections.Generic;

namespace DataLayer.Entities.Cars
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavoriteCars { get; }
        Car GetObjectCar(int carId);
        IEnumerable<Car> FindCarsByCategory(string category);
    }
}

using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface ICarsRepository
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavoriteCars { get; }
        Car GetObjectCar(int carId);
        IEnumerable<Car> FindCarsByCategory(string category);
    }
}

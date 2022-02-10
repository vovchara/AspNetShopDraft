using AspNetShop.Data.Models;
using System.Collections.Generic;

namespace AspNetShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<CarModel> AllCars { get; }
        IEnumerable<CarModel> GetFavCars { get; set; }
        CarModel GetCar(int carId);
    }
}

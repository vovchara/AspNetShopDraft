using AspNetShop.Data.Models;
using System.Collections.Generic;

namespace AspNetShop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<CarModel> AllCars { get; set; }
        public string CurrentCategory { get; set; }
    }
}

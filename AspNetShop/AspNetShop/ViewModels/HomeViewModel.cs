using AspNetShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<CarModel> FavCars { get; set; }
    }
}

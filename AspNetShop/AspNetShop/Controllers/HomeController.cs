using AspNetShop.Data.Interfaces;
using AspNetShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars carRepository;

        public HomeController(IAllCars carRepository)
        {
            this.carRepository = carRepository;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavCars = carRepository.GetFavCars
            };
            return View(homeCars);
        }
    }
}

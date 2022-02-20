using AspNetShop.Data.Interfaces;
using AspNetShop.Data.Models;
using AspNetShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AspNetShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars allCars, ICarsCategory allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            IEnumerable<CarModel> cars = null;
            var currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.AllCars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.AllCars.Where(i => i.Category.CategoryName.Equals("Elector cars")).OrderBy(i => i.Id);
                    currCategory = "Електро";
                }
                else if (string.Equals("fuel", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.AllCars.Where(i => i.Category.CategoryName.Equals("Classic cars")).OrderBy(i => i.Id);
                    currCategory = "Коптілки";
                }
            }
            var csrVM = new CarsListViewModel
            {
                AllCars = cars,
                CurrentCategory = currCategory
            };

            ViewBag.Title = "Сторінка з автомобілями";

            return View(csrVM);
        }
    }
}

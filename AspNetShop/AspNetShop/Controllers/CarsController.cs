using AspNetShop.Data.Interfaces;
using AspNetShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

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

        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з автомобілями";
            var listVM = new CarsListViewModel();
            listVM.AllCars = _allCars.AllCars;
            listVM.CurrentCategory = "Cars";
            return View(listVM);
        }
    }
}

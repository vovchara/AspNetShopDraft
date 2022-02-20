using AspNetShop.Data.Interfaces;
using AspNetShop.Data.Models;
using AspNetShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AspNetShop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars carRepository;
        private readonly ShopCart shopCart;

        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            this.carRepository = carRepository;
            this.shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = shopCart.GetShopItems();
            shopCart.ListShopItems = items;

            var viewModel = new ShopCartViewModel
            {
                ShopCart = shopCart
            };

            return View(viewModel);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = carRepository.AllCars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                shopCart.AddToCart(item, 1);
            }
            return RedirectToAction("Index");
        }
    }
}

using AspNetShop.Data.Interfaces;
using AspNetShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<CarModel> AllCars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<CarModel> GetFavCars => appDBContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public CarModel GetCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.Id == carId);
    }
}

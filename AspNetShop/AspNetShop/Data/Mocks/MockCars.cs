using AspNetShop.Data.Interfaces;
using AspNetShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<CarModel> AllCars
        {
            get
            {
                return new List<CarModel>
                {
                    new CarModel { Name = "Tesla Model S",
                        ShortDesc = "Fast one",
                        LongDesc = "3 sec to 100 km h. Omg wtf",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().First()
                    },
                    new CarModel {
                        Name = "Ford Fiesta",
                        ShortDesc = "Slow shit",
                        LongDesc = "13 sec to 100 km h. Small city car",
                        Img = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarModel {
                        Name = "BMW M3",
                        ShortDesc = "Fast one, expensive",
                        LongDesc = "4 sec to 100 km h. Vidro bude lomatys",
                        Img = "/img/m3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarModel {
                        Name = "Mercedes C class",
                        ShortDesc = "Pafosno",
                        LongDesc = "Majorno pafosno for misto zbs",
                        Img = "/img/mercedes.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarModel {
                        Name = "Nissan Leaf",
                        ShortDesc = "Deshevo i serdyto",
                        LongDesc = "Bystro, deshevo, ale ne daleko",
                        Img = "/img/nissan.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().First()
                    }
                };
            }
        }

        public IEnumerable<CarModel> GetFavCars { get; set; }

        public CarModel GetCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

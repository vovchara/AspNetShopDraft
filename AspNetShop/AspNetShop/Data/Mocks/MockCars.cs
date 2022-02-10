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
                        Img = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Tesla_Model_S_02_2013.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().First()
                    },
                    new CarModel {
                        Name = "Ford Fiesta",
                        ShortDesc = "Slow shit",
                        LongDesc = "13 sec to 100 km h. Small city car",
                        Img = "https://www.winnerauto.ua/uploads/gallery_photo/photo/0170/91.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarModel {
                        Name = "BMW M3",
                        ShortDesc = "Fast one, expensive",
                        LongDesc = "4 sec to 100 km h. Vidro bude lomatys",
                        Img = "https://upload.wikimedia.org/wikipedia/commons/8/8a/BMW_M3_Competition_%28G80%29_IMG_4041.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarModel {
                        Name = "Mercedes C class",
                        ShortDesc = "Pafosno",
                        LongDesc = "Majorno pafosno for misto zbs",
                        Img = "https://upload.wikimedia.org/wikipedia/commons/5/52/Mercedes-Benz_C_200_Avantgarde_%28W_205%29_%E2%80%93_Frontansicht%2C_26._April_2014%2C_D%C3%BCsseldorf.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = _categoryCars.GetAllCategories().Last()
                    },
                    new CarModel {
                        Name = "Nissan Leaf",
                        ShortDesc = "Deshevo i serdyto",
                        LongDesc = "Bystro, deshevo, ale ne daleko",
                        Img = "https://upload.wikimedia.org/wikipedia/commons/3/3a/2019_Nissan_Leaf_N-Connecta.jpg",
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

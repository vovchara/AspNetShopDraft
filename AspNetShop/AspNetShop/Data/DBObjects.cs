using AspNetShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace AspNetShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories().Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                     new CarModel
                     {
                         Name = "Tesla Model S",
                         ShortDesc = "Fast one",
                         LongDesc = "3 sec to 100 km h. Omg wtf",
                         Img = "/img/tesla.jpg",
                         Price = 45000,
                         IsFavourite = true,
                         Available = true,
                         Category = category["Elector cars"]
                     },
                    new CarModel
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Slow shit",
                        LongDesc = "13 sec to 100 km h. Small city car",
                        Img = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = category["Classic cars"]
                    },
                    new CarModel
                    {
                        Name = "BMW M3",
                        ShortDesc = "Fast one, expensive",
                        LongDesc = "4 sec to 100 km h. Vidro bude lomatys",
                        Img = "/img/m3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = category["Classic cars"]
                    },
                    new CarModel
                    {
                        Name = "Mercedes C class",
                        ShortDesc = "Pafosno",
                        LongDesc = "Majorno pafosno for misto zbs",
                        Img = "/img/mercedes.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        Available = false,
                        Category = category["Classic cars"]
                    },
                    new CarModel
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Deshevo i serdyto",
                        LongDesc = "Bystro, deshevo, ale ne daleko",
                        Img = "/img/nissan.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        Available = true,
                        Category = category["Elector cars"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, CategoryModel> category;
        private static Dictionary<string, CategoryModel> Categories()
        {
            if (category == null)
            {
                //category = new Dictionary<string, CategoryModel>();
                //category.Add("Elector cars", new CategoryModel { CategoryName = "Elector cars", Description = "Drive the future" });
                //category.Add("Classic cars", new CategoryModel { CategoryName = "Classic cars", Description = "Cars with fuel driven engine" });

                var result = new List<CategoryModel>();
                result.Add(new CategoryModel { CategoryName = "Elector cars", Description = "Drive the future" });
                result.Add(new CategoryModel { CategoryName = "Classic cars", Description = "Cars with fuel driven engine" });
                category = result.ToDictionary(k => k.CategoryName);
            }
            return category;
        }
    }
}

using AspNetShop.Data.Interfaces;
using AspNetShop.Data.Models;
using System.Collections.Generic;

namespace AspNetShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<CategoryModel> GetAllCategories()
        {
            var result = new List<CategoryModel>();
            result.Add(new CategoryModel { CategoryName = "Elector cars", Description = "Drive the future" });
            result.Add(new CategoryModel { CategoryName = "Classic cars", Description = "Cars with fuel driven engine" });
            return result;
        }
    }
}

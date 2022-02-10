using AspNetShop.Data.Models;
using System.Collections.Generic;

namespace AspNetShop.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<CategoryModel> GetAllCategories();
    }
}

using System.Collections.Generic;

namespace AspNetShop.Data.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<CarModel> Cars { get; set; }
    }
}

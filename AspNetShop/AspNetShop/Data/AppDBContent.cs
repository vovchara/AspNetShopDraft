using AspNetShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetShop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        public DbSet<CarModel> Car { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<OrderModel> Order { get; set; }
        public DbSet<OrderDetailModel> OrderDetail { get; set; }
    }
}

using AspNetShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetShop.Data.Interfaces
{
    public interface IAllOrders
    {
        void CreateOrder(OrderModel order);
    }
}

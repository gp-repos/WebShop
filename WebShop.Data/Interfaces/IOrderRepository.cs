using System.Collections.Generic;
using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Data.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> CheckOut(Order order);
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}

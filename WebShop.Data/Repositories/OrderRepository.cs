using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebShop.Core.Entities;
using WebShop.Data.Interfaces;

namespace WebShop.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        protected readonly AppDbContext _dbContext;

        public OrderRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Order> CheckOut(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserName(string userName)
        {
            var orderList = await _dbContext.Orders.Include(o=>o.Buyer)
                            .Where(o => o.Buyer.UserName == userName)
                            .ToListAsync();

            return orderList;
        }
    }
}

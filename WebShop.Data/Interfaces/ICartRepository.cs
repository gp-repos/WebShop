﻿using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Data.Interfaces
{
    public interface ICartRepository
    {
        Task<Cart> GetCartByUserName(string userName);
        Task AddItem(string userName, int productId, int quantity = 1, string color = "Black");
        Task RemoveItem(int cartId, int cartItemId);
        Task ClearCart(string userName);
    }
}

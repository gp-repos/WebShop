using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Data.Interfaces;
using WebShop.Web.ViewModels;

namespace WebShop.Web.ViewComponents
{
    public class ShoppingCart : ViewComponent
    {
        private readonly ICartRepository _cartRepository;
      //  private readonly SignInManager<ApplicationUser> _signInManager;

        public ShoppingCart(ICartRepository cartRepository)//, SignInManager<ApplicationUser> signInManager)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
        //    _signInManager = signInManager;
    }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vm = new ShoppingCartViewModel
            {
                ItemsCount = await CountTotalCartItems()
            };
            return View(vm);
        }

        private async Task<int> CountTotalCartItems()
        {
            /* if (_signInManager.IsSignedIn(HttpContext.User))
             {
                 return await _basketService.CountTotalBasketItems(User.Identity.Name);
             }

             string anonymousId = GetAnnonymousIdFromCookie();
             if (anonymousId == null)
                 return 0;*/

            var cart = await _cartRepository.GetCartByUserName("test");

            return cart.Items?.Count ?? 0;
        }

        private string GetAnnonymousIdFromCookie()
        {
          /*  if (Request.Cookies.ContainsKey(Constants.BASKET_COOKIENAME))
            {
                var id = Request.Cookies[Constants.BASKET_COOKIENAME];

                if (Guid.TryParse(id, out var _))
                {
                    return id;
                }
            }*/
            return null;
        }


    }
}
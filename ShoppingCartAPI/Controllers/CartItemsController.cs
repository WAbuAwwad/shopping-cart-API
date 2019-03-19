using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopping_cart;

namespace ShoppingCartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : Controller
    {
        

        // Get api/cartItems
        [HttpGet]
        public List<cartItem> Get()
        {
            return data.MyShoppingCart.Items;
        }
        [HttpGet("{price}/{taxe}")]
        public void Get(double price, double taxe)
        {
            item myItem = new item(price, taxe, shopping_cart.Type.Most_groceries_and_food_items);
            cartItem myCartItem = new cartItem(myItem, 1, false, 0.0, 1, 1);
            data.MyShoppingCart.AddItem(myCartItem);
          
        }



    }
}
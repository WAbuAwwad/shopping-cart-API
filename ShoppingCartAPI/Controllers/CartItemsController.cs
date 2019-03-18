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
    public class CartItemsController : ControllerBase
    {

        shoppingCart shoppingCart = new shoppingCart("$");
        [HttpGet]
        public List<cartItem> Get()
        {

            return shoppingCart.Items;
        }

        // POST api/cartItems
        [HttpPost]
        public void Post([FromBody] cartItem item )
        {
            shoppingCart.AddItem(item);
        }

    }
}
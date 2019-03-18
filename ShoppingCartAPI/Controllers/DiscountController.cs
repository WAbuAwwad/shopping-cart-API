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
    public class DiscountController : ControllerBase
    {
        // GET api/discount
        [HttpGet]
        public double Get()
        {
            shoppingCart shoppingCart = new shoppingCart("$");
            calculateDiscount discount = new calculateDiscount(shoppingCart);
            return discount.CalculateDiscount(); 
        }
    }
}
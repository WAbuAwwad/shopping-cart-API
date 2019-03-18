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
    public class TotalController : ControllerBase
    {
        // GET api/total
        [HttpGet]
        public double Get()
        {
            shoppingCart shoppingCart = new shoppingCart("$");
            calculateTotal total = new calculateTotal(shoppingCart);
            return total.CalculateTotal();
        }
    }
}
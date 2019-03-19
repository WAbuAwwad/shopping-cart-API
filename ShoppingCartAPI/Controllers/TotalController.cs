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
    public class TotalController : Controller
    {
      
        // GET api/total
        [HttpGet]
        public double Get()
        {
            calculateTotal total = new calculateTotal(data.MyShoppingCart);
            return total.CalculateTotal();
        }
    }
}
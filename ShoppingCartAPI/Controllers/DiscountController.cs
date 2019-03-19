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
    public class DiscountController : Controller
    {
        
        // GET api/discount
        [HttpGet]
        public double Get()
        { 
            calculateDiscount discount = new calculateDiscount(data.MyShoppingCart);
            return discount.CalculateDiscount(); 
        }
    }
}
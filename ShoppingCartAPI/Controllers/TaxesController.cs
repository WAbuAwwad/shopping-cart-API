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
    public class TaxesController : Controller
    {
        
        // GET api/taxes
        [HttpGet]
        public double Get()
        {
            calculateTaxes taxes = new calculateTaxes(data.MyShoppingCart);
            return taxes.CalculateTaxes();
        }

    }
}
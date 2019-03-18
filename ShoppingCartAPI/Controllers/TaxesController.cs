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
    public class TaxesController : ControllerBase
    {

        // GET api/taxes
        [HttpGet]
        public double Get()
        {
            shoppingCart shoppingCart = new shoppingCart("$");
            calculateTaxes taxes = new calculateTaxes(shoppingCart);
            return taxes.CalculateTaxes();
        }

    }
}
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
    public class PaymentController : Controller
    {

        
        // GET api/payment
        [HttpGet]
        public double Get()
        {
            calculatePayment payment = new calculatePayment(data.MyShoppingCart);
            return payment.payment();
        }

    }
}
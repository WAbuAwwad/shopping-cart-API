using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shopping_cart;

namespace ShoppingCartAPI.Controllers
{
    
    public class data 
    {
        public static shoppingCart MyShoppingCart= new shoppingCart("$");

    }

}
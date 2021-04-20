using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class CookieController : Controller
    {
        public void ShoppingcartCreate()
        {
            HttpContext.Response.Cookies.Append("Shoppingcart","");
        }

        //shoppingcart add items
        public void ShoppingcartAddItems(int id , int quantity)
        {
            string test = Request.Cookies["shoppingcart"];
           
        }
        //shoppingcart deleteitems
        public void ShoppingCartDeleteIteem(int id , int quantity)
        {

        }
        //login cookie create

       
    }
}

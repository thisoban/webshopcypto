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
        public void ShoppingcartAddItems(int id , int qauntity)
        {
            string test = Request.Cookies["shoppingcart"];
           
        }
        //shoppingcart deleteitems

        //login cookie create

        public void Login(int id)
        {
            HttpContext.Response.Cookies.Append("User", id.ToString());
        }
        //logout cookie destroy
        public void Logout()
        {
            Response.Cookies.Delete("user");    
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using DAL;
using Logic;
using RestSharp;

namespace WebApplication.Controllers
{
    public class AuthController : Controller
    {

        private readonly UserManager _userManager;
        // GET: ProductController
        public AuthController(MyContext context)
        {
            _userManager = new UserManager(context);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginForm)
        {
            if (_userManager.CheckUser(loginForm.Username, loginForm.Password))
            {
               User user = _userManager.GetUserByName(loginForm.Username);
                HttpCookie userInfo = new HttpCookie();
                userInfo.Expires.AddDays(2);
                userInfo.Value = user.Id.ToString();
               
            }
                return View(loginForm);
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel registerForm)
        {
            //TODO
            try
            {
                return Redirect("/home");
            }
            catch (Exception)
            {

                throw;
            } 
        }

        [HttpGet]
        public IActionResult Logout()
        {
          //  await _signInManager.SignOutAsync();
            return Redirect("/home");
        }
    }
}

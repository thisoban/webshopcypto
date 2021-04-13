using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginForm)
        {
                return View();
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

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

        public AuthController()
        { 
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginForm)
        {
                return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerForm)
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
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
          //  await _signInManager.SignOutAsync();
            return Redirect("/home");
        }
    }
}

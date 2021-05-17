using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using Logic;
using Logic.Interfaces;
using DAL.Database;
using RestSharp;

namespace WebApplication.Controllers
{
    public class AuthController : Controller
    {

        private readonly IUserLogic _userLogic;
        // GET: ProductController
        public AuthController(MyContext context )
        {
            _userLogic = new UserLogic(context);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginForm)
        {
            User formuser = new User()
            {
                Username = loginForm.Username,
                Password = loginForm.Password
            };
            if (_userLogic.CheckUserIsValid(loginForm.Username, loginForm.Password))
            {
               User user = _userLogic.GetUserByName(formuser);
               
                string test = "test";
                Response.Cookies.Append(test, user.Id.ToString());

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

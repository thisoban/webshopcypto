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
using DAL;

namespace WebApplication.Controllers
{
    public class AuthController : Controller
    {

        private readonly IUserLogic _userLogic;
        // GET: ProductController
        public AuthController( IUserLogic logic)
        {
            _userLogic = logic;
        }
        public IActionResult Login()
        {
            LoginViewModel login = new LoginViewModel();
            login.ErrorMessage = null;
            return View(login);
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginForm)
        {
            if (loginForm.Username != "" && loginForm.Password != "")
            {
                User formuser = new User()
                {
                    Username = loginForm.Username,
                    Password = loginForm.Password
                };
                if (_userLogic.CheckUserIsValid(loginForm.Username, loginForm.Password))
                {
                    User user = _userLogic.GetUserByName(formuser);

                    string userlogin = "user";
                    
                    Response.Cookies.Append(userlogin, $"{user.Id},{user.Firstname}, {user.role.Id}");
                    return Redirect("../Home/Index");
                }
                loginForm.ErrorMessage = "please fill in correct username or password";
                return View(loginForm);
            }
            loginForm.ErrorMessage = "please fill in the fields";
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
            if (registerForm.Password == registerForm.PasswordRepeat)
            {
                try
                {
                    User user = new User()
                    {
                        Username = registerForm.Username,
                        Email = registerForm.Email,
                        Password = registerForm.Password,
                        Firstname = registerForm.Firstname
                    };
                    Customer customer = new Customer()
                    {
                        Street = registerForm.Street,
                        Housenumber = registerForm.Housenumber,
                        Housenumberintial = registerForm.Housenumberintial,
                        Zipcode = registerForm.Zipcode,
                        ZipcodeCharacter = registerForm.ZipcodeCharacter,
                        City = registerForm.City,
                        User = user
                    };

                    _userLogic.CreateUser(user);
                return Redirect("/home");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return View();
           
        }

        [HttpGet]
        public IActionResult Logout()
        {
            //  await _signInManager.SignOutAsync();
            Response.Cookies.Delete("user");
            return Redirect("/home");
        }
    }
}

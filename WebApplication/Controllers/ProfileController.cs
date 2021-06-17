using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic.Interfaces;

namespace WebApplication.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserLogic _logic;
        public ProfileController(IUserLogic logic) => _logic = logic;
        // GET: ProfileController1
        public ActionResult Index()
        {
          
            return View();
        }

        // GET: ProfileController1/Details/5
        public ActionResult Details()
        {
            //laat profiel zien
            string username = Request.Cookies["user"].Split(',')[1];
            User user = new User() { Username = username };

            User userdetail = _logic.GetUserByName(user);
            //Request.Cookies;
            return View(userdetail);
        }


        // GET: ProfileController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfileController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfileController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //public async Task<Customer> GetCustomerByUserId(string userId)
        //{
        //   throw await 
        //}

    }
}

using DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class ProfileController1 : Controller
    {
        // GET: ProfileController1
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: ProfileController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfileController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfileController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

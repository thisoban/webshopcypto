using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class OrderController : Controller
    {
        // GET: ORderController
        public ActionResult Index()
        {
            //get all order from that person

            //or get orders as admin
            return View();
        }

        // GET: ORderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ORderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ORderController/Create
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

        // GET: ORderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ORderController/Edit/5
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

        // GET: ORderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ORderController/Delete/5
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
    }
}

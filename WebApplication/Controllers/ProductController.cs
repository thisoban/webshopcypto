using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using DAL;
using Logic;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductManager _productManager;
        // GET: ProductController
        public ProductController()
        {
          _productManager = new ProductManager();
        }
        public ActionResult Index()
        {
            return View(_productManager.GetAllproducts());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View(_productManager.GetProduct(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product collection)
        {
            try
            {
                _productManager.CreateProduct(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_productManager.GetProduct(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                _productManager.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(product);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_productManager.GetProduct(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
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

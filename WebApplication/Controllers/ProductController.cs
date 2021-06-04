using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using DAL;
using Logic;
using DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Database;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductLogic _ProductLogic;
        // GET: ProductController
        public ProductController( )
        {
          _ProductLogic = new ProductLogic(new ProductDal());
        }
        public ActionResult Index()
        {
            try
            {
                _ProductLogic.ListOfProducts();
            }catch()
            {

            }
            rView();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            Product product = _ProductLogic.GetProduct(id);

            if (product != null)
            {
                return View(product);
            }

            return View();
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
            if (_ProductLogic.CreateProduct(collection))
            {
                return RedirectToAction(nameof(Index));
            }
            return View(collection);
            
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_ProductLogic.GetProduct(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            if (_ProductLogic.UpdateProduct(product))
            {
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_ProductLogic.GetProduct(id));
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Logic.Interfaces;
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
        //private readonly ProductLogic _ProductLogic;
        private readonly IProductLogic _Iproductlogic;
        // GET: ProductController
        public ProductController( IProductLogic productLogic) => _Iproductlogic = productLogic;
        
        public ActionResult Index()
        {
            try
            {
                return View(_Iproductlogic.ListOfProducts());
            }catch(Exception e)
            {
                string error = e.Message ;
                return View();
            }
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                Product product = _Iproductlogic.GetProduct(id);

                if (product != null)
                {
                    return View(product);
                }
            }
            catch
            {
                //give error and show details vieww
                RedirectToAction("index");
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
            try
            {
                _Iproductlogic.CreateProduct(collection);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View(collection);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_Iproductlogic.GetProduct(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                _Iproductlogic.UpdateProduct(product);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                //implement error
                return View(product);
            } 
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_Iproductlogic.GetProduct(id));
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

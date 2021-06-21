using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Logic.Interfaces;
using DAL;
using Logic;
using DataModel;
using WebApplication.Models;
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
                List<Product> products = _Iproductlogic.ListOfProducts();
                List<ProductViewModel> viewproduct = new List<ProductViewModel>();
                foreach (Product item in products)
                {
                    ProductViewModel product = new ProductViewModel(item);
                    viewproduct.Add(product);
                }
                
                return View();
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
                ProductViewModel productVM = new ProductViewModel(product);

                if (product != null)
                {
                    return View(productVM);
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
                ProductViewModel productVM = new ProductViewModel();
                // dogus comment, omdat je in je DataModel in de constructor van Product geen viewmodel kan meegeven heb ik het even zo gedaan. PS. je stinkt.
                collection.Id = productVM.Id;
                collection.Name = productVM.Name;
                collection.Description = productVM.Description;
                collection.Quantity = productVM.Quantity;
                collection.SellPrice = productVM.SellPrice;
                collection.Buyprice = productVM.Buyprice;
                collection.Serialnumber = productVM.Serialnumber;

                _Iproductlogic.CreateProduct(collection);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View(collection);
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            // idk of dit juist is check jij het maar
            Product product = _Iproductlogic.GetProduct(id);
            ProductViewModel productVM = new ProductViewModel(product);
            return View(productVM);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Edit(int id, ProductViewModel productVM)
        {
            try
            {
                Product product = new Product();
                // idk of ik hier Id van viewmodel moet pakken of van de edit(int id) zelf
                product.Id = productVM.Id;
                product.Name = productVM.Name;
                product.Description = productVM.Description;
                product.Quantity = productVM.Quantity;
                product.SellPrice = productVM.SellPrice;
                product.Buyprice = productVM.Buyprice;
                product.Serialnumber = productVM.Serialnumber;


                _Iproductlogic.UpdateProduct(product);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                if(e.Equals(new NullReferenceException()))
                {
                    return View();
                }
                //implement error
                return View(productVM);
            } 
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            Product product = _Iproductlogic.GetProduct(id);
            return View(product);
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

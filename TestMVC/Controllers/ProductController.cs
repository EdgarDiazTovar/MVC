using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            try
            {
                using (var db = new ProductContext())
                {
                    return View(db.Products.ToList());
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error - " + ex.Message);
                return View();
            }
        }

        public ActionResult add()
        {
            return View();
        }
       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult add(Product p)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (var db = new ProductContext())
                {
                    db.Products.Add(p);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("","Error to create new - " + ex.Message);
                return View();
            }    
        }

        public ActionResult Edit(int id)
        {
            try
            {
                using (var db = new ProductContext())
                {
                    Product prod = db.Products.Find(id);
                    return View(prod);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Can't find the element - " + ex.Message);
                return View();
            }

                
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product p)
        {
            try
            {
                using (var db = new ProductContext())
                {
                    Product prod2 = db.Products.Find(p.id);
                    prod2.Name = p.Name;
                    prod2.Quantity = p.Quantity;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Can't find the element - " + ex.Message);
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            try
            {
                using (var db = new ProductContext())
                {
                    Product prod2 = db.Products.Find(id);
                    return View(prod2);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Can't show details - " + ex.Message);
                return View();
            }

        }
        
        public ActionResult Delete(int id)
        {
            try
            {
                using (var db = new ProductContext())
                {
                    Product prod2 = db.Products.Find(id);
                    db.Products.Remove(prod2);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Can't delete the product - " + ex.Message);
                return View();
            }
        }
    }
}
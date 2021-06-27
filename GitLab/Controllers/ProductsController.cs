using GitLab.Models;
using GreenLifeStore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitLab.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Products = _db.Products.ToList();
            ViewData["Products"] = Products;
            return View();
        }
        // GET: /products/id
        public IActionResult Details(int? id)
        {
            var Product = _db.Products.ToList().Find(product => product.ProductId == id);
            if (id == null || Product == null)
            {
                return View("_NotFound");
            }
            ViewData["Product"] = Product;
            return View(Product);

        }

        //GET- /products/edit/id
        public IActionResult Edit(int? id)
        {
            var Product = _db.Products.ToList().Find(p => p.ProductId == id);
            if (id == null || Product == null)
            {
                return View("_NotFound");
            }
            ViewData["Product"] = Product;
            return View();
        }
        //POST - /products/edit/id
        [HttpPost]
        public IActionResult Edit(int id, [Bind("ProductId", "Name", "Price")] ProductModel product)
        {
            var Product = _db.Products.ToList().Find(p => p.ProductId == id);
            Product.Name = product.Name;
            Product.Price = product.Price;
            _db.Products.Update(Product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

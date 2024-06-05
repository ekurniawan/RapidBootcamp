using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidBootcamp.WebApplication.Models;

namespace RapidBootcamp.WebApplication.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: CategoriesController
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { CategoryId = 1, CategoryName = "Laptop" });
            categories.Add(new Category { CategoryId = 2, CategoryName = "Smartphone" });
            categories.Add(new Category { CategoryId = 3, CategoryName = "Tablet" });
            categories.Add(new Category { CategoryId = 4, CategoryName = "Desktop" });
            categories.Add(new Category { CategoryId = 5, CategoryName = "Smartwatch" });

            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
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

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
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

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
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

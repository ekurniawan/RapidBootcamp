using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RapidBootcamp.WebApplication.DAL;
using RapidBootcamp.WebApplication.Models;

namespace RapidBootcamp.WebApplication.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategory _categoryDal;
        public CategoriesController(ICategory categoryDal)
        {
            _categoryDal = categoryDal;
        }

        // GET: CategoriesController
        public ActionResult Index()
        {
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
            }

            var categories = _categoryDal.GetAll();

            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var category = _categoryDal.GetById(id);
            return View(category);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                var result = _categoryDal.Add(category);

                TempData["Message"] = $"Category {category.CategoryName} added successfully";

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.ErrorMessage = "Category not added";
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id, string nama, string alamat)
        {
            return Content($"Id yang akan diedit: {id} - {nama} - {alamat}");
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

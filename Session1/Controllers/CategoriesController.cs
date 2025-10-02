using Microsoft.AspNetCore.Mvc;
using Session1.Data;
using Session1.Models;

namespace Session1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var categories = context.Categories.ToList();
            return View("Index", categories);
        }
        public ViewResult Details(int id)
        {
            var category = context.Categories.Find(id);
            return View("Details", category);
        }
        public ViewResult Create()
        {
            return View("Create",new Category());
        }
        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(request);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create",request);
        }
        public IActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var category = context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            var existing = context.Categories.Find(category.Id);

            if (existing == null)
            {
                return NotFound();
            }

            existing.Name = category.Name;
            existing.Description = category.Description;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost("/categories/update")]
        public IActionResult Update(Category category)
        {
            var existing = context.Categories.Find(category.Id);
            if (existing == null)
            {
                return NotFound();
            }

            existing.Name = category.Name;
            existing.Description = category.Description;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

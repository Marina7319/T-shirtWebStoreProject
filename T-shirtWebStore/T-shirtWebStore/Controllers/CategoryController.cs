using Microsoft.AspNetCore.Mvc;
using System.Linq;
using T_shirtWebStore.Data;
using T_shirtWebStore.Models;

namespace T_shirtWebStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _app; 
        public CategoryController(ApplicationDbContext app)
        {
            _app = app;
        }
        public IActionResult Index()
        {
            List<Category> categories = _app.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot match the name");
            }
            //if (category.Name != null && category.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid value");
            //}
            if (ModelState.IsValid)
            {
                _app.Categories.Add(category);
                _app.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Category? category = _app.Categories.Find(id);
            //Category? categoryTwo = _app.Categories.FirstOrDefault(x=>x.Id==id);
            //Category? categoryThree = _app.Categories.Where(u=>u.Id==id).FirstOrDefault();
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
         
            //if (category.Name == category.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The DisplayOrder cannot match the name");
            //}
            //if (category.Name != null && category.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid value");
            //}
            if (ModelState.IsValid)
            {
                _app.Categories.Update(category);
                _app.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
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
    }
}

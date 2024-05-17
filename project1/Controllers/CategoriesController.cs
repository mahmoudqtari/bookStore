using Microsoft.AspNetCore.Mvc;
using project1.Data;

namespace project1.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext context;
        public CategoriesController( ApplicationDbContext context)
        {
            this.context = context; 

        }
        public IActionResult Index()
        {
            var categories = context.categories.ToList();
            return View(categories);
        }
    }
}

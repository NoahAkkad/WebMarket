using Microsoft.AspNetCore.Mvc;
using WebMarket.Data;
using WebMarket.Models;

namespace WebMarket.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Category> opjCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}


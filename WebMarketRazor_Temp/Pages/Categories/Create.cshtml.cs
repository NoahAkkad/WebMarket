using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebMarketRazor_Temp.Data;
using WebMarketRazor_Temp.Models;

namespace WebMarketRazor_Temp.Pages.Categories
{
    //[BindProperties] for all Properties or You can use this Properties or one [BindProperty]   
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category updated successfuly";
            return RedirectToPage("Index");
        }
    }
}

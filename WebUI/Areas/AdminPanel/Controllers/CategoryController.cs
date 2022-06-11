using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebUI.DAL;
using WebUI.Models;
using WebUI.ViewModels.Categoryy;

namespace WebUI.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        private AppDbContext _context { get; }
        private IEnumerable<Categories> categories;
        public CategoryController(AppDbContext context)
        {
            _context = context;
            categories = _context.Categories.Where(ct => !ct.IsDeleted);
        }
        [Area("AdminPanel")]
        public IActionResult Index()
        {
            return View(categories);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreatVM category)
        {
            if (!ModelState.IsValid) return View();
            bool isExist = false;
            foreach (var ct in categories)
            {
                if (category.Name.ToLower() == ct.Name.ToLower())
                {
                    isExist = true; break;
                }
            }
            if (isExist)
            {
                ModelState.AddModelError("Name", $"{category.Name} is Exist");
                return View();
            }
            Categories NewCategory = new Categories
            {
                Name = category.Name
            };
            await _context.Categories.AddAsync(NewCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}

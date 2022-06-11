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
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private AppDbContext _context { get; }
        private IEnumerable<Categories> categories;
        public CategoryController(AppDbContext context)
        {
            _context = context;
            categories = _context.Categories.Where(ct => !ct.IsDeleted);
        }
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

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            Categories categoryDb = _context.Categories.Where(c => c.IsDeleted).FirstOrDefault(c => c.Id == id);
            if (categoryDb == null)
                return NotFound();
            // _context.Categories.Remove(categoryDb);
            categoryDb.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return BadRequest();
            Categories category = _context.Categories.Where(c => !c.IsDeleted).FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Categories category)
        {
            if (id == null)
                return BadRequest();
            Categories categoryDb = _context.Categories.Where(c => c.IsDeleted).FirstOrDefault(c => c.Id == id);
            if (categoryDb == null)
                return NotFound();
            //if (category.Name.ToLower() == categoryDb.Name.ToLower())
            //    return RedirectToAction(nameof(Index));
            bool isExist = categories.Where(ct => !ct.IsDeleted)
                .Any(ct => ct.Name.ToLower() == category.Name.ToLower() && ct.Id != category.Id);
            if (isExist)
            {
                ModelState.AddModelError("Name", $"{category.Name} is Exist");
                return View();
            }
            categoryDb.Name = category.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
    
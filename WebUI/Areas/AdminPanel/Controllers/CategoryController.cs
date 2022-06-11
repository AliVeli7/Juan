using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebUI.DAL;
using WebUI.Models;

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
            return View();
        }
    }
}

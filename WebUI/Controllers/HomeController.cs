using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebUI.DAL;
using WebUI.Models;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Slides = _context.Slides.ToList(),
                Features = _context.Features.ToList(),
                Categories = _context.Categories.Where(c => !c.IsDeleted)
                .Include(pc => pc.prCategories).ThenInclude(ct => ct.Product).ToList(),
                Products = _context.Products.Where(p => !p.isDeleted).Include(p => p.Images).ToList(),
                Blogs = _context.Blogs.ToList(),
                Brands = _context.Brands.ToList()
            };

            return View(home);
        }

        

        
    }
}

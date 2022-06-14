using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.DAL;
using WebUI.ViewModels;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public ShopController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            ShopViewModel shop = new ShopViewModel
            {
                Products = _context.Products.Include(p => p.Images).Include(p => p.Categories).ThenInclude(pc => pc.Category)
                .Where(p => !p.isDeleted ).Take(9).ToList(),
                Categories = _context.Categories.Where(ct => !ct.IsDeleted)
                .Include(pc => pc.prCategories).ThenInclude(ct => ct.Product).ToList(),
                Colors = _context.Colors.ToList()
            };
            return View(shop);
        }
    }
}

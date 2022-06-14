using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.DAL;
using WebUI.ViewModels;

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
                .Where(p => !p.isDeleted ).ToList(),
            };
            return View(shop);
        }
    }
}

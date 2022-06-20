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
using PagedList;

namespace WebUI.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        private int _count { get; }
        public ShopController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            _count = context.Products.Where(p => !p.isDeleted).Count();
        }
        public IActionResult Index(int? page)
        {
            ShopViewModel shop = new ShopViewModel
            {
                 pageSize = 3,
                 pageNumber = (page ?? 1),
                 products = _context.Products.Where(c => !c.isDeleted)
                .Include(p => p.Images).Include(p => p.Categories).OrderByDescending(p => p.Id)
                .ToList(),
                Categories = _context.Categories.Where(ct => !ct.IsDeleted)
                .Include(pc => pc.prCategories).ThenInclude(ct => ct.Product).ToList(),
                Colors = _context.Colors.ToList()
                
            };
            return View(shop);
        }

        public IActionResult Detail(int? Id)
        {

            List<Products> products = _context.Products.Include(p => p.Images).Include(p => p.Categories).ThenInclude(pc => pc.Category).Where(pr => pr.Id == Id && pr.isDeleted == false).ToList();
            return View(products);

        }

        
    }
}

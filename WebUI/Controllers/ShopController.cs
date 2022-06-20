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
        private int _count { get; }
        public ShopController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            _count = context.Products.Where(p => !p.isDeleted).Count();
        }
        public IActionResult Index()
        {
            ShopViewModel shop = new ShopViewModel
            {
                Products = _context.Products.Where(c => !c.isDeleted)
                .Include(p => p.Images).Include(p => p.Categories).OrderByDescending(p => p.Id)
                .Take(8).ToList(),
                Categories = _context.Categories.Where(ct => !ct.IsDeleted)
                .Include(pc => pc.prCategories).ThenInclude(ct => ct.Product).ToList(),
                Colors = _context.Colors.ToList()
            };
            return View(shop);
        }

        public IActionResult Detail(int? Id)
        {
            ShopViewModel shop = new ShopViewModel
            {
                Products = _context.Products.Include(p => p.Images).Include(p => p.Categories).ThenInclude(pc => pc.Category).Where(pr => pr.Id == Id && pr.isDeleted == false).ToList(),
            };
            return View(shop);

        }

        public IActionResult LoadProducts(int skip = 8)
        {
            if (skip >= _count)
            {
                return BadRequest();
            }
            List<Products> products = _context.Products.Where(c => !c.isDeleted)

                .Include(p => p.Images).Include(p => p.Categories).OrderByDescending(p => p.Id)
                .Skip(skip).Take(10).ToList();
            //return Json(products);
            return PartialView("_ProductPartial", products);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.DAL;
using WebUI.Models;
using WebUI.ViewModels.ProductViewModel;

namespace WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        private IEnumerable<Products> products;
        public ProductController(AppDbContext context)
        {
            _context = context;
            products = _context.Products.Include(p => p.Images).Include(p => p.Categories).ThenInclude(pc => pc.Category)
                  .Where(p => !p.isDeleted).Take(6).ToList();
        }
        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateVM product)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!product.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Image size must be smaller than 200kb");
                return View();
            }
            if (!product.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file  must be image");
                return View();
            }
            Product NewProduct = new Product
            {
                Title = product.Title,
                Count = product.Count,
                Price = product.Price,
                CategoryId = categoryId
            };
            await _context.Products.AddAsync(NewProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

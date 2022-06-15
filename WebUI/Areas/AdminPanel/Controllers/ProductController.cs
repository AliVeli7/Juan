using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.DAL;
using WebUI.Helpers;
using WebUI.Models;
using WebUI.ViewModels.ProductViewModel;

namespace WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        private IEnumerable<Products> products;
        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
            products = _context.Products.Include(p => p.Images).Include(p => p.Categories).ThenInclude(pc => pc.Category)
                  .Where(p => !p.isDeleted).ToList();
        }
        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.colors = _context.Colors.ToList();
            ViewBag.categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products product,int colorId)
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
            Products NewProduct = new Products
            {
                Name = product.Name,
                Price = product.Price,
               
            };
            string image = await product.Photo.SaveFileAsync(_env.WebRootPath, "assets/img/product");
            ProductColors productcolor = new ProductColors()
            {
                ColorId = colorId
            };

            ProductImages productImages = new ProductImages
            {
                Url = image
            };
            List<ProductImages> images = new List<ProductImages>();
            List<ProductColors> colors = new List<ProductColors>();
            images.Add(productImages);
            colors.Add(productcolor);
            NewProduct.Images = images;
            NewProduct.Colors = colors;
            await _context.Products.AddAsync(NewProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            Products productDb = _context.Products.Where(c => !c.isDeleted).FirstOrDefault(c => c.Id == id);
            if (productDb == null)
                return NotFound();
            // _context.Products.Remove(ProductDb);
            productDb.isDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.colors = _context.Colors.ToList();
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Products newProduct, int colorId)
        {
            if (id == null)
            {

            }
            var ProductDb = _context.Products.Find(id);
            if (ProductDb == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!newProduct.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "Image size must be smaller than 200kb");
                return View();
            }
            if (!newProduct.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "Type of file  must be image");
                return View();
            }
            Products UpdatedProduct = new Products
            {
                Name = newProduct.Name,
                Price = newProduct.Price,

            };
            string image = await newProduct.Photo.SaveFileAsync(_env.WebRootPath, "assets/img/product");
            ProductColors productcolor = new ProductColors()
            {
                ColorId = colorId
            };

            ProductImages productImages = new ProductImages
            {
                Url = image
            };
            List<ProductImages> images = new List<ProductImages>();
            List<ProductColors> colors = new List<ProductColors>();
            images.Add(productImages);
            colors.Add(productcolor);
            UpdatedProduct.Images = images;
            UpdatedProduct.Colors = colors;
            Products productDb = _context.Products.Where(c => !c.isDeleted).FirstOrDefault(c => c.Id == id);
            productDb.isDeleted = true;
            await _context.Products.AddAsync(UpdatedProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}

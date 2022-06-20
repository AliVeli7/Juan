using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.DAL;
using WebUI.Models;

namespace WebUI.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        private AppDbContext _context { get; }
        public ProductsViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Products> products = _context.Products.Where(p => !p.isDeleted).Include(p => p.Images).Include(c => c.Categories).OrderByDescending(p => p.Id).Take(8).ToList();
            return View(await Task.FromResult(products));
        }
    }
}

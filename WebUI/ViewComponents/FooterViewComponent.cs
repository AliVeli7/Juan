using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.DAL;

namespace WebUI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private AppDbContext _context { get; }
        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
            return View(model);
        }
    }
}

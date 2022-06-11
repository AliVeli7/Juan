using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        [Area("AdminPanel")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

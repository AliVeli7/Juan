﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.AdminPanel.Controllers
{
    public class SlideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

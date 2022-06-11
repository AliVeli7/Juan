using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class HomeViewModel
    {
        public List<Sliders> Slides { get; set; }
        public List<Features> Features { get; set; }
        public List<Products> Products { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Blogs> Blogs { get; set; }
        public List<Brands> Brands { get; set; }
        public List<Colors> Colors { get; set; }
        public List<Settings> Settings { get; set; }

    }
}

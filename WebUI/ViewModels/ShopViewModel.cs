using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class ShopViewModel
    {
        public List<Products> Products { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Colors> Colors { get; set; }
    }
}

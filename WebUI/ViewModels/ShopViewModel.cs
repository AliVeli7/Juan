using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class ShopViewModel
    {
        public int pageNumber;
        public int pageSize;

        public List<Products> products { get; set; }
        public IPagedList<Products> Products { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Colors> Colors { get; set; }
    }
}

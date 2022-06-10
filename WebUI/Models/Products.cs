using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Products
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public int DiscountPercent { get; set; }
        public int Description { get; set; }
        public bool IsinStock { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool isNew { get; set; }
        public List<ProductImages> Images { get; set; }
        public List<ProductColors> Colors { get; set; }
        public List<ProductCategories> Categories { get; set; }
    }
}

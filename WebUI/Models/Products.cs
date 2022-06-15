using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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
        public ICollection<ProductImages> Images { get; set; }
        public ICollection<ProductColors> Colors { get; set; }
        public ICollection<ProductCategories> Categories { get; set; }
        [NotMapped, Required]
        public ICollection<IFormFile> Photos { get; set; }
    }
}

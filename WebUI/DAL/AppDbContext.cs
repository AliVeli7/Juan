using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.DAL
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        { }
        public DbSet<Sliders> Slides { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<ProductColors> ProductColours { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ProductCategories> ProductsCategories { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Settings> Settings { get; set; }
    }
}

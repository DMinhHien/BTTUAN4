using BTTUAN4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTUAN4.Database
{
    internal class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }

        private const string ConString = "Data Source=localhost;Initial Catalog=QuanLySanPham;Integrated Security=True;TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConString);
        }
     
    }
}

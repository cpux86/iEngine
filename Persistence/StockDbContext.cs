using Application.Interfaces;
using Domain.Entities;
using Domain.Entities.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Persistence.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class StockDbContext : DbContext, IStockDbContext
    {
        public StockDbContext(DbContextOptions options) :  base(options) { }


        //public DbSet<ProductBox> ProductBoxes { get; set; }

        public DbSet<Document> Documents { get; set; } = null!;
        
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Warehouse> Warehouses { get; set; } = null!;
        //public DbSet<Cell> Cells { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Card> Cards { get ; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

        }
    }
}

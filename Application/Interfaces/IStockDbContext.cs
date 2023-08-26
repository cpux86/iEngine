using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.ProductAggregate;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Internal;

namespace Application.Interfaces
{
    public interface IStockDbContext
    {
        //DbSet<ProductBox> ProductBoxes { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<Card> Cards { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Box> Boxes { get; set; }

        DbSet<User> Users { get; set; }
        DbSet<Warehouse> Warehouses { get; set; }
        DbSet<Barcode> Barcodes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
    }
}

using Domain.Entities.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //builder.HasMany(p => p.Boxes)
            //    .WithMany(b => b.Products)
            //    .UsingEntity<ProductBox>(
            //        j => j
            //            .HasOne(pt => pt.Box)
            //            .WithMany(p => p.ProductBoxes)
            //            .HasForeignKey(pt => pt.BoxId),
            //        j => j
            //            .HasOne(pt => pt.Product)
            //            .WithMany(t => t.ProductBoxes)
            //            .HasForeignKey(pt => pt.ProductId),

            //        j =>
            //        {
            //            j.HasKey(t => new { t.ProductId, t.BoxId });
            //            j.ToTable("ProductBoxes");
            //        });



            //builder.ToTable("Product");


            //builder
            //    .HasOne(r => r.Product)
            //    .WithMany(c => c.Orders)
            //    .HasForeignKey(r => r.ProductBarcode)
            //    .HasPrincipalKey(c => c.Barcode);
        }
    }
}

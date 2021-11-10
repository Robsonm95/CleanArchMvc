using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Price).HasPrecision(10, 2);
            builder.HasOne(e => e.Category).WithMany(e => e.Products).HasForeignKey(e => e.CategoryId);

            builder.HasData(
                new Product(1, "Caderno espiral", "Caderno espiral 100 folhas", 8, 50, "caderno1.jpg", 1),
                new Product(2, "Estojo escolar", "Estojo escolar cinza", 6, 70, "estojo1.jpg", 1),
                new Product(3, "Borracha escolar", "Borracha escolar pequena", 3, 80, "borracha.jpg", 1)
            );
        }
    }
}

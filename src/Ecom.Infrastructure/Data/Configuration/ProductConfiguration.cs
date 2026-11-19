using System;
using Ecom.Core.Entities.product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecom.Infrastructure.Data.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
        builder.Property(p => p.Name).HasMaxLength(30).IsRequired();
        builder.Property(p => p.Description).HasMaxLength(500).IsRequired();
        builder.Property(p => p.Price).IsRequired();
        builder.HasMany(p => p.Photos)
               .WithOne(p => p.Product)
               .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(c => c.Category)
               .WithMany(p => p.Products)
               .HasForeignKey(c => c.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);

        var categoryId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        var productId = Guid.Parse("22222222-2222-2222-2222-222222222222");
        builder.HasData(
            new Product
            {
                Id = productId,
                Description = "MY SEED DESCRIPTION",
                Name = "MY SEED NAME",
                Price =12,
                CategoryId = categoryId,


            }
        );
        
        
    }
}

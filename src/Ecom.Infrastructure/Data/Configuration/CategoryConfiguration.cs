using System;
using Ecom.Core.Entities.product;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Infrastructure.Data.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Description).HasMaxLength(500);
        builder.HasMany(c => c.Products)
               .WithOne(p => p.Category)
               .OnDelete(DeleteBehavior.Cascade);


        builder.HasData(
            new Category
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "MY SEED NAME",
                Description = "MY SEED Description"
            }
        );
        
    }
}

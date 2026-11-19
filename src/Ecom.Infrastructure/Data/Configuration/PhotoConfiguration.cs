using System;
using Ecom.Core.Entities.product; // أو المسار الذي توجد فيه كلاساسات الكيانات لديك
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecom.Infrastructure.Data.Configuration;

public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
{
    public void Configure(EntityTypeBuilder<Photo> builder)
    {
        builder.Property(p => p.ImageName)
                .IsRequired()
                .HasMaxLength(255);

        builder.HasKey(p => p.Id);

        builder.Property(p => p.ImageName)
               .IsRequired();

        builder.HasOne(p => p.Product)
               .WithMany(prod => prod.Photos)
               .HasForeignKey(p => p.ProductId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
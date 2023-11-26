using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionDemo.Domain;

namespace OnionDemo.Persistence.src.Data
{
    public static class ProductMapping
    {
        public static void OnModelCreating(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("PK_PRODUCT");
            builder.Property(c => c.Name).HasColumnName("TX_NAME").HasMaxLength(100).IsFixedLength();
            builder.Property(c => c.Description).HasColumnName("TX_DESCRIPTION");
            builder.Property(c => c.Price).HasColumnName("NO_PRICE");
            builder.Property(c => c.CategoryId).HasColumnName("FK_CATEGORY_ID");
            builder.Property(c => c.Created).HasColumnName("DT_CREATED");
            builder.Property(c => c.IsDel).HasColumnName("SW_DEL");

            builder.HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId)
            .HasConstraintName("FK_Product_Category");
        }
    }
}
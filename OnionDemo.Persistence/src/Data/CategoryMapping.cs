using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionDemo.Domain.Category;

namespace OnionDemo.Persistence.src.Data
{
    public static class CategoryMapping
    {
        public static void OnModelCreating(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("PK_CATEGORY");
            builder.Property(c => c.Name).HasColumnName("TX_NAME").HasMaxLength(100).IsFixedLength();
            builder.Property(c => c.Description).HasColumnName("TX_DESCRIPTION");
            builder.Property(c => c.Created).HasColumnName("DT_CREATED");   
            builder.Property(c => c.IsDel).HasColumnName("SW_DEL");
        }
    }
}

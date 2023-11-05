using Microsoft.EntityFrameworkCore;
using OnionDemo.Domain;
using OnionDemo.Persistence.src.Data;

namespace OnionDemo.Persistence.src.Context.Main
{
    public partial class MainDbContext : DbContext
    {
        public MainDbContext()
        {
        }

        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(ProductMapping.OnModelCreating);
            modelBuilder.Entity<Product>().ToTable("PRODUCT");

            modelBuilder.Entity<Category>(CategoryMapping.OnModelCreating);
            modelBuilder.Entity<Category>().ToTable("CATEGORY");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore;
using OnionDemo.Domain;
using OnionDemo.Persistence.src.Context.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnionDemo.Persistence.src.Data
{
    public class DataSeeder
    {
        private readonly ModelBuilder _modelBuilder;

        public DataSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            _modelBuilder.Entity<Category>().HasData(
                  new Category
                  {
                      Id = Guid.Parse("B1F04949-FB5F-4286-9F2A-2F8B0C06E7DE"),
                      Name = "Kategori 2",
                      Description = "Kategori 2 açıklaması.",
                      Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                      IsDel = false
                  },
                     new Category
                     {
                         Id = Guid.Parse("0DE8E949-21F7-45E7-9D4E-536B30072D35"),
                         Name = "Kategori 5",
                         Description = "Kategori 5 açıklaması.",
                         Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                         IsDel = false
                     },
                     new Category
                     {
                         Id = Guid.Parse("3D60E3E9-DA05-47A7-9CC5-6FA19995E781"),
                         Name = "Kategori 3",
                         Description = "Kategori 3 açıklaması.",
                         Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                         IsDel = false
                     },
                     new Category
                     {
                         Id = Guid.Parse("4A3221B5-2DA5-44B0-AAC4-78B6728A3717"),
                         Name = "Kategori 4",
                         Description = "Kategori 4 açıklaması.",
                         Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                         IsDel = false
                     },
                     new Category
                     {
                         Id = Guid.Parse("E4F41D7D-6D47-4B24-9A4F-91E7D7741F28"),
                         Name = "Kategori 1",
                         Description = "Kategori 1 açıklaması.",
                         Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                         IsDel = false
                     });

            _modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.Parse("A696F00D-3A2E-48BF-88BB-1F3F416570FB"),
                    CategoryId = Guid.Parse("3D60E3E9-DA05-47A7-9CC5-6FA19995E781"),
                    Name = "Ürün 7",
                    Price = 80,
                    Description = "Ürün 7 açıklaması.",
                    Created = DateTime.Parse("2023-11-03 22:05:26.000"),
                    IsDel = false
                },
                    new Product
                    {
                        Id = Guid.Parse("63B179CC-5C4E-44F2-9B9A-49A74416BB80"),
                        CategoryId = Guid.Parse("B1F04949-FB5F-4286-9F2A-2F8B0C06E7DE"),
                        Name = "Ürün 4",
                        Price = 120,
                        Description = "Ürün 4 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("5F7FE0F9-07B7-45D3-A3E9-4E39DE2E4423"),
                        CategoryId = Guid.Parse("4A3221B5-2DA5-44B0-AAC4-78B6728A3717"),
                        Name = "Ürün 10",
                        Price = 75,
                        Description = "Ürün 10 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("D6661D2F-8B78-4C24-9CB3-578C62AB35A1"),
                        CategoryId = Guid.Parse("0DE8E949-21F7-45E7-9D4E-536B30072D35"),
                        Name = "Ürün 13",
                        Price = 95,
                        Description = "Ürün 13 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("B542BC9F-EC79-4A2E-9180-7A4A97C74A72"),
                        CategoryId = Guid.Parse("E4F41D7D-6D47-4B24-9A4F-91E7D7741F28"),
                        Name = "Ürün 3",
                        Price = 200,
                        Description = "Ürün 3 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("2EFDD11B-B2C5-470E-8A7B-960E4711483D"),
                        CategoryId = Guid.Parse("3D60E3E9-DA05-47A7-9CC5-6FA19995E781"),
                        Name = "Ürün 9",
                        Price = 140,
                        Description = "Ürün 9 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("A394E328-2B8F-4D4A-8F56-A41E7C0A3C46"),
                        CategoryId = Guid.Parse("B1F04949-FB5F-4286-9F2A-2F8B0C06E7DE"),
                        Name = "Ürün 5",
                        Price = 180,
                        Description = "Ürün 5 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("E824ABFD-CA71-4E09-9EAC-A9D590EF42D2"),
                        CategoryId = Guid.Parse("0DE8E949-21F7-45E7-9D4E-536B30072D35"),
                        Name = "Ürün 15",
                        Price = 155,
                        Description = "Ürün 15 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("DF34CC80-B98E-4AF3-8EAA-B7A76AAE66FC"),
                        CategoryId = Guid.Parse("4A3221B5-2DA5-44B0-AAC4-78B6728A3717"),
                        Name = "Ürün 11",
                        Price = 105,
                        Description = "Ürün 11 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("E0160C83-A45D-49DA-A1AC-C8B88CDB84FB"),
                        CategoryId = Guid.Parse("0DE8E949-21F7-45E7-9D4E-536B30072D35"),
                        Name = "Ürün 2",
                        Price = 1500,
                        Description = "Ürün 2 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.000"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("607A4E57-4AE4-4770-9F63-CDEB1D7E9F52"),
                        CategoryId = Guid.Parse("4A3221B5-2DA5-44B0-AAC4-78B6728A3717"),
                        Name = "Ürün 12",
                        Price = 135,
                        Description = "Ürün 12 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("85C4848C-ADFD-4E47-8AFB-CE572A1B0A8A"),
                        CategoryId = Guid.Parse("3D60E3E9-DA05-47A7-9CC5-6FA19995E781"),
                        Name = "Ürün 8",
                        Price = 110,
                        Description = "Ürün 8 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("5F9668B0-F70F-45EE-A9A6-CF6D845D1E25"),
                        CategoryId = Guid.Parse("E4F41D7D-6D47-4B24-9A4F-91E7D7741F28"),
                        Name = "Ürün 1",
                        Price = 100,
                        Description = "Ürün 1 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.000"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("8E6B2EC8-C5E3-47AC-8E4D-F02A00C82B2B"),
                        CategoryId = Guid.Parse("0DE8E949-21F7-45E7-9D4E-536B30072D35"),
                        Name = "Ürün 14",
                        Price = 125,
                        Description = "Ürün 14 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    },
                    new Product
                    {
                        Id = Guid.Parse("EC6CEC30-AC14-4B61-A1F4-F0E7C5E69D72"),
                        CategoryId = Guid.Parse("B1F04949-FB5F-4286-9F2A-2F8B0C06E7DE"),
                        Name = "Ürün 6",
                        Price = 220,
                        Description = "Ürün 6 açıklaması.",
                        Created = DateTime.Parse("2023-11-03 22:05:26.790"),
                        IsDel = false
                    });
        }
    }
}
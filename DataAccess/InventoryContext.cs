using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-ROP98T4\SQLEXPRESS;Database=InventoryDb;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categorias = CargarCategorias();
            var bodegas = CargarBodegas();
            var productos = CargarProductos(categorias);

            modelBuilder.Entity<CategoryEntity>().HasData(categorias);
            modelBuilder.Entity<WarehouseEntity>().HasData(bodegas);
            modelBuilder.Entity<ProductEntity>().HasData(productos);
        }

        private IEnumerable<CategoryEntity> CargarCategorias()
        {
            List<CategoryEntity> resultado = new List<CategoryEntity>
            {
                new CategoryEntity { CategoryId = Guid.NewGuid(), ShortName = "ASH", Name = "Aseo del Hogar" },
                new CategoryEntity { CategoryId = Guid.NewGuid(), ShortName = "ASP", Name = "Aseo Personal" },
                new CategoryEntity { CategoryId = Guid.NewGuid(), ShortName = "HGR", Name = "Hogar" },
                new CategoryEntity { CategoryId = Guid.NewGuid(), ShortName = "PRF", Name = "Perfumeria" },
                new CategoryEntity { CategoryId = Guid.NewGuid(), ShortName = "SLD", Name = "Salud" },
                new CategoryEntity { CategoryId = Guid.NewGuid(), ShortName = "VDJ", Name = "Video Juegos" }
            };

            return resultado;
        }

        private IEnumerable<WarehouseEntity> CargarBodegas()
        {
            List<WarehouseEntity> resultado = new List<WarehouseEntity>
            {
                new WarehouseEntity { WarehouseId = Guid.NewGuid(), Name = "Bodega Central", Address = "3416 Reel Avenue" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid(), Name = "Bodega Norte", Address = "317 Evergreen Lane" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid(), Name = "Bodega Sur", Address = "2072 Hidden Pond Road" }
            };

            return resultado;
        }

        private IEnumerable<ProductEntity> CargarProductos(IEnumerable<CategoryEntity> categorias)
        {
            List<ProductEntity> resultado = new List<ProductEntity>();
            Random rand = new Random();
            foreach (var item in categorias)
            {
                for (int i = 1; i <= rand.Next(3, 5); i++)
                {
                    resultado.Add(new ProductEntity { ProductId = Guid.NewGuid(), CategoryId = item.CategoryId, Name = $"{item.Name} {i}" });
                }
            }

            return resultado;
        }
    }
}

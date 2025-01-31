﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20201010082502_TestData")]
    partial class TestData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"),
                            Name = "Aseo del Hogar",
                            ShortName = "ASH"
                        },
                        new
                        {
                            CategoryId = new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"),
                            Name = "Aseo Personal",
                            ShortName = "ASP"
                        },
                        new
                        {
                            CategoryId = new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"),
                            Name = "Hogar",
                            ShortName = "HGR"
                        },
                        new
                        {
                            CategoryId = new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"),
                            Name = "Perfumeria",
                            ShortName = "PRF"
                        },
                        new
                        {
                            CategoryId = new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"),
                            Name = "Salud",
                            ShortName = "SLD"
                        },
                        new
                        {
                            CategoryId = new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"),
                            Name = "Video Juegos",
                            ShortName = "VDJ"
                        });
                });

            modelBuilder.Entity("Entities.InputOutputEntity", b =>
                {
                    b.Property<Guid>("InputOutputId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInput")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("StorageId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InputOutputId");

                    b.HasIndex("StorageId");

                    b.ToTable("InputOutputs");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("35f71451-1a24-4558-b843-5b81d7e0a91a"),
                            CategoryId = new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"),
                            Name = "Aseo del Hogar 1",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("5f14bb35-1f97-4298-bd63-174c6f3699fe"),
                            CategoryId = new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"),
                            Name = "Aseo del Hogar 2",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("47120b67-800d-4977-ab04-c33274b013e3"),
                            CategoryId = new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"),
                            Name = "Aseo del Hogar 3",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("e46d55a1-9608-4e2a-9e1e-ef140d93909b"),
                            CategoryId = new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"),
                            Name = "Aseo Personal 1",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("3d5a8fe2-0d0c-4a5c-9fb3-9a2c52a8d674"),
                            CategoryId = new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"),
                            Name = "Aseo Personal 2",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("0a978e04-9fdf-42b5-84c4-a44874d60c08"),
                            CategoryId = new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"),
                            Name = "Aseo Personal 3",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("0dc96688-69fc-4de1-aefa-56e9353cadef"),
                            CategoryId = new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"),
                            Name = "Aseo Personal 4",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("f21039a3-87b8-422f-889b-88615f4f5fa1"),
                            CategoryId = new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"),
                            Name = "Hogar 1",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("8e3dd4a3-1b53-4943-894e-440b2e17086a"),
                            CategoryId = new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"),
                            Name = "Hogar 2",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("46ed77e6-61d5-4383-90c0-4a54bb534d1b"),
                            CategoryId = new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"),
                            Name = "Hogar 3",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("1da6e51a-78d1-41bd-bf81-86a871b100d9"),
                            CategoryId = new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"),
                            Name = "Perfumeria 1",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("067712d1-8195-46d2-9d38-04de0b8708f4"),
                            CategoryId = new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"),
                            Name = "Perfumeria 2",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("e5e8bdf6-397c-483c-9abf-884455cf135b"),
                            CategoryId = new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"),
                            Name = "Perfumeria 3",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("9b49f3ea-3efd-408c-bf8b-646a3fb5fd13"),
                            CategoryId = new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"),
                            Name = "Salud 1",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("d2ea8927-15e5-4e58-985a-f87c5865ffa3"),
                            CategoryId = new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"),
                            Name = "Salud 2",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("b9df0a0a-916b-47de-896c-62ecee79d68a"),
                            CategoryId = new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"),
                            Name = "Salud 3",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("4bdf8b1c-bb72-4b9b-99b5-a4e239a98e6d"),
                            CategoryId = new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"),
                            Name = "Video Juegos 1",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("e4b6ef65-4961-4c5f-a16c-88f9e521d1bb"),
                            CategoryId = new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"),
                            Name = "Video Juegos 2",
                            TotalQuantity = 0
                        },
                        new
                        {
                            ProductId = new Guid("e74bc6dc-773b-4e79-a0ab-8836f90d07c9"),
                            CategoryId = new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"),
                            Name = "Video Juegos 3",
                            TotalQuantity = 0
                        });
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<Guid>("StorageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WarehouseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StorageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entities.WarehouseEntity", b =>
                {
                    b.Property<Guid>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            WarehouseId = new Guid("4e3fde28-f17d-46b2-b3ee-6c16129c9fbb"),
                            Address = "3416 Reel Avenue",
                            Name = "Bodega Central"
                        },
                        new
                        {
                            WarehouseId = new Guid("3e162337-5cd1-4edc-98c5-0015988cc4f8"),
                            Address = "317 Evergreen Lane",
                            Name = "Bodega Norte"
                        },
                        new
                        {
                            WarehouseId = new Guid("7f5f9b70-30a9-4841-b5b7-090da213b627"),
                            Address = "2072 Hidden Pond Road",
                            Name = "Bodega Sur"
                        });
                });

            modelBuilder.Entity("Entities.InputOutputEntity", b =>
                {
                    b.HasOne("Entities.StorageEntity", "Storage")
                        .WithMany("InputOutputs")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.HasOne("Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.WarehouseEntity", "Warehouse")
                        .WithMany("Storages")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

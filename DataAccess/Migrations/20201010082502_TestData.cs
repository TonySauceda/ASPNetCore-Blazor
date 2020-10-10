using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"), "Aseo del Hogar", "ASH" },
                    { new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"), "Aseo Personal", "ASP" },
                    { new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"), "Hogar", "HGR" },
                    { new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"), "Perfumeria", "PRF" },
                    { new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"), "Salud", "SLD" },
                    { new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"), "Video Juegos", "VDJ" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("4e3fde28-f17d-46b2-b3ee-6c16129c9fbb"), "3416 Reel Avenue", "Bodega Central" },
                    { new Guid("3e162337-5cd1-4edc-98c5-0015988cc4f8"), "317 Evergreen Lane", "Bodega Norte" },
                    { new Guid("7f5f9b70-30a9-4841-b5b7-090da213b627"), "2072 Hidden Pond Road", "Bodega Sur" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "TotalQuantity" },
                values: new object[,]
                {
                    { new Guid("35f71451-1a24-4558-b843-5b81d7e0a91a"), new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"), null, "Aseo del Hogar 1", 0 },
                    { new Guid("4bdf8b1c-bb72-4b9b-99b5-a4e239a98e6d"), new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"), null, "Video Juegos 1", 0 },
                    { new Guid("b9df0a0a-916b-47de-896c-62ecee79d68a"), new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"), null, "Salud 3", 0 },
                    { new Guid("d2ea8927-15e5-4e58-985a-f87c5865ffa3"), new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"), null, "Salud 2", 0 },
                    { new Guid("9b49f3ea-3efd-408c-bf8b-646a3fb5fd13"), new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"), null, "Salud 1", 0 },
                    { new Guid("e5e8bdf6-397c-483c-9abf-884455cf135b"), new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"), null, "Perfumeria 3", 0 },
                    { new Guid("067712d1-8195-46d2-9d38-04de0b8708f4"), new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"), null, "Perfumeria 2", 0 },
                    { new Guid("1da6e51a-78d1-41bd-bf81-86a871b100d9"), new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"), null, "Perfumeria 1", 0 },
                    { new Guid("e4b6ef65-4961-4c5f-a16c-88f9e521d1bb"), new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"), null, "Video Juegos 2", 0 },
                    { new Guid("46ed77e6-61d5-4383-90c0-4a54bb534d1b"), new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"), null, "Hogar 3", 0 },
                    { new Guid("f21039a3-87b8-422f-889b-88615f4f5fa1"), new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"), null, "Hogar 1", 0 },
                    { new Guid("0dc96688-69fc-4de1-aefa-56e9353cadef"), new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"), null, "Aseo Personal 4", 0 },
                    { new Guid("0a978e04-9fdf-42b5-84c4-a44874d60c08"), new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"), null, "Aseo Personal 3", 0 },
                    { new Guid("3d5a8fe2-0d0c-4a5c-9fb3-9a2c52a8d674"), new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"), null, "Aseo Personal 2", 0 },
                    { new Guid("e46d55a1-9608-4e2a-9e1e-ef140d93909b"), new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"), null, "Aseo Personal 1", 0 },
                    { new Guid("47120b67-800d-4977-ab04-c33274b013e3"), new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"), null, "Aseo del Hogar 3", 0 },
                    { new Guid("5f14bb35-1f97-4298-bd63-174c6f3699fe"), new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"), null, "Aseo del Hogar 2", 0 },
                    { new Guid("8e3dd4a3-1b53-4943-894e-440b2e17086a"), new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"), null, "Hogar 2", 0 },
                    { new Guid("e74bc6dc-773b-4e79-a0ab-8836f90d07c9"), new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"), null, "Video Juegos 3", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("067712d1-8195-46d2-9d38-04de0b8708f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a978e04-9fdf-42b5-84c4-a44874d60c08"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0dc96688-69fc-4de1-aefa-56e9353cadef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1da6e51a-78d1-41bd-bf81-86a871b100d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("35f71451-1a24-4558-b843-5b81d7e0a91a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3d5a8fe2-0d0c-4a5c-9fb3-9a2c52a8d674"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("46ed77e6-61d5-4383-90c0-4a54bb534d1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("47120b67-800d-4977-ab04-c33274b013e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4bdf8b1c-bb72-4b9b-99b5-a4e239a98e6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5f14bb35-1f97-4298-bd63-174c6f3699fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8e3dd4a3-1b53-4943-894e-440b2e17086a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9b49f3ea-3efd-408c-bf8b-646a3fb5fd13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9df0a0a-916b-47de-896c-62ecee79d68a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2ea8927-15e5-4e58-985a-f87c5865ffa3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e46d55a1-9608-4e2a-9e1e-ef140d93909b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4b6ef65-4961-4c5f-a16c-88f9e521d1bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e5e8bdf6-397c-483c-9abf-884455cf135b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e74bc6dc-773b-4e79-a0ab-8836f90d07c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f21039a3-87b8-422f-889b-88615f4f5fa1"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: new Guid("3e162337-5cd1-4edc-98c5-0015988cc4f8"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: new Guid("4e3fde28-f17d-46b2-b3ee-6c16129c9fbb"));

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: new Guid("7f5f9b70-30a9-4841-b5b7-090da213b627"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2a313fa4-e211-42e2-a7ae-3406d9509b38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("7e65276a-e9b6-4bdc-868b-0e4b23d948f5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("84cb2192-f0d3-4f59-84dc-22ffb2d41ea0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("925cda32-0090-40eb-a8b5-eebe9f9c9d1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("c1407449-e6eb-449c-9162-250e5d24bf7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("eb6cbdf9-572b-4492-bc19-c0eee6107d2f"));
        }
    }
}

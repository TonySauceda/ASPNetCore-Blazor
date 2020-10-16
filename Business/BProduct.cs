using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business
{
    public static class BProduct
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(ProductEntity product)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(product);

                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity product)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Update(product);

                db.SaveChanges();
            }
        }

        public static ProductEntity ProductById(Guid productId)
        {
            using (var db = new InventoryContext())
            {
                return db.Products.FirstOrDefault(x => x.ProductId == productId);
            }
        }
    }
}

using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business
{
    public class BStorage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages
                    .Include(x => x.Warehouse)
                    .Include(x => x.Product)
                    .ToList();
            }
        }

        public static void CreateStorage(StorageEntity storage)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(storage);

                db.SaveChanges();
            }
        }

        public static void UpdateStorage(StorageEntity storage)
        {
            using (var db = new InventoryContext())
            {
                storage.LastUpdate = DateTime.Now;
                db.Storages.Update(storage);

                db.SaveChanges();
            }
        }

        public static bool IsProductInWarehouse(Guid productId, Guid warehouseId)
        {
            using (var db = new InventoryContext())
            {
                var product = db.Storages
                    .Where(x =>
                        x.WarehouseId == warehouseId &&
                        x.ProductId == productId);

                return product.Any();
            }
        }

        public static List<StorageEntity> StorageListByWarehouse(Guid warehouseId)
        {
            using (var db = new InventoryContext())
            {
                return db.Storages
                    .Include(x => x.Warehouse)
                    .Include(x => x.Product)
                    .Where(x => 
                        x.WarehouseId == warehouseId)
                    .ToList();
            }
        }
    }
}

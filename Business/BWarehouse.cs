using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BWarehouse
    {
        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static void CreateWarehouset(WarehouseEntity warehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Warehouses.Add(warehouse);

                db.SaveChanges();
            }
        }

        public static void UpdateWarehouse(WarehouseEntity warehouse)
        {
            using (var db = new InventoryContext())
            {
                db.Warehouses.Update(warehouse);

                db.SaveChanges();
            }
        }

        public static WarehouseEntity WarehouseById(Guid warehouseId)
        {
            using (var db = new InventoryContext())
            {
                return db.Warehouses.FirstOrDefault(x => x.WarehouseId == warehouseId);
            }
        }
    }
}

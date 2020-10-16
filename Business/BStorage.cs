using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BStorage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
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
                db.Storages.Update(storage);

                db.SaveChanges();
            }
        }
    }
}

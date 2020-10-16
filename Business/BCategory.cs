using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business
{
    public class BCategory
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.ToList();
            }
        }

        public static void CreateCategory(CategoryEntity category)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Add(category);

                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity category)
        {
            using (var db = new InventoryContext())
            {
                db.Categories.Update(category);

                db.SaveChanges();
            }
        }

        public static CategoryEntity CategoryById(Guid categoryId)
        {
            using (var db = new InventoryContext())
            {
                return db.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
            }
        }
    }
}

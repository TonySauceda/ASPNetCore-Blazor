using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class BInputOutput
    {
        public static List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventoryContext())
            {
                return db.InputOutputs
                    .Include(x => x.Storage)
                    .ThenInclude(x => x.Warehouse)
                    .Include(x => x.Storage)
                    .ThenInclude(x => x.Product)
                    .ToList();
            }
        }

        public static void CreateInputOutput(InputOutputEntity inputOutput)
        {
            using (var db = new InventoryContext())
            {
                inputOutput.Date = DateTime.Now;
                db.InputOutputs.Add(inputOutput);

                db.SaveChanges();
            }
        }

        public static void UpdateInputOutput(InputOutputEntity inputOutput)
        {
            using (var db = new InventoryContext())
            {
                db.InputOutputs.Update(inputOutput);

                db.SaveChanges();
            }
        }
    }
}

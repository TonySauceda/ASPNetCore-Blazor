﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        public Guid StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }

        //Relación con producto
        public Guid ProductId { get; set; }
        public ProductEntity Product { get; set; }

        //Relación con Bodega
        public Guid WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }

        //Relació con movimientos
        public IEnumerable<InputOutputEntity> InputOutputs { get; set; }

        [NotMapped]
        public string WarehouseIdString
        {
            get => WarehouseId.ToString();
            set => WarehouseId = Guid.TryParse(value, out Guid temp) ? temp : default;
        }
        [NotMapped]
        public string ProductIdString
        {
            get => ProductId.ToString();
            set => ProductId = Guid.TryParse(value, out Guid temp) ? temp : default;

        }
    }
}

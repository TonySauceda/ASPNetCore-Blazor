using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        public Guid WarehouseId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        //Relación con almacenes
        public IEnumerable<StorageEntity> Storages { get; set; }
    }
}

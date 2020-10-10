using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key]
        public Guid InputOutputId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsInput { get; set; }

        //Relación con almacen
        public Guid StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(600)]
        public string Description { get; set; }
        public int TotalQuantity { get; set; }

        //Relación con categoria
        public Guid CategoryId { get; set; }
        public CategoryEntity Category { get; set; }

        //Relación con almacenes
        public IEnumerable<StorageEntity> Storages { get; set; }
    }
}

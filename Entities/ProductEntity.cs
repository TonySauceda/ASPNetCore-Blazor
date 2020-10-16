using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        public Guid ProductId { get; set; } = Guid.NewGuid();
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

        [NotMapped]
        public string ProductIdString
        {
            get => ProductId.ToString();
            set => ProductId = Guid.TryParse(value, out Guid temp) ? temp : default;
        }
        [NotMapped]
        public string CategoryIdString
        {
            get => CategoryId.ToString();
            set => CategoryId = Guid.TryParse(value, out Guid temp) ? temp : default;

        }

    }
}

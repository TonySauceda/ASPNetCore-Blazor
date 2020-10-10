using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string ShortName { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        //Relación con productos
        public IEnumerable<ProductEntity> Products { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryManager.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }

        [StringLength(maximumLength: 50)]
        public string Description { get; set; }

        [StringLength(maximumLength: 20)]
        public string Category { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }
    }
}

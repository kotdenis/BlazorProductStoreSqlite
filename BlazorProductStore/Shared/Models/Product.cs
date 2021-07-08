using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace BlazorProductStore.Shared.Models
{
    public partial class Product
    {
        public Product()
        {
            Cartlines = new HashSet<Cartline>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }

        public virtual ICollection<Cartline> Cartlines { get; set; }
    }
}

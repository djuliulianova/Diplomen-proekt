using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Domain
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }
        [Required]

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Picture { get; set; }
        [Required]
        [Range(0, 5000)]

        public int Quantity { get; set; }
        [Required]
        [Range(0, 10000)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 10000)]
        //[Column(TypeName = "decimal(18,2)")]
        public decimal Discount { get; set; }
        [Required]
        public string Material { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();


    }
}

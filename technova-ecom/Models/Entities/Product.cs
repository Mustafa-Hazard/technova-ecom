using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    [Table("Products")]
    public class Product
    {

        // attributes for the Product class
        [Column("ProductId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Column("Name")]
        public string Name { get; set; }
        
        [Column("Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        
        [Column("Price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Column("StockQuantity")]
        [Display(Name = "Stock Quantity")]
        public int StockQuantity { get; set; }
        [Column("Rating")]
        [Display(Name = "Rating")]

        public int Rating{ get; set; }

    }
}

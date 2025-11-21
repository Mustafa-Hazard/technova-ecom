using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using technova_ecom.Models.Entities;

namespace technova_ecom.Models.Entities
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("category_name")]
        public string CategoryName { get; set; }
        [Column("display_order")]
        public int DisplayOrder { get; set; }

        // Navigation Property - One Category has Many Products
        public ICollection<Product>? Products { get; set; }
    }
}

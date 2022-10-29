using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace EcommerceAPI.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Required]
        public string Pname { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}

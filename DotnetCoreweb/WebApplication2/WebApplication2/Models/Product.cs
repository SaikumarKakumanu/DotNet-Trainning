using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required(ErrorMessage ="Enter Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage="Enter Product Quntity")]
        public int ProductQty { get; set; }
        public float ProductPrice { get; set; }
        
    }
}

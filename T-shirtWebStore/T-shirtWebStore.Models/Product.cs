using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace T_shirtWebStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }


        [Required]
        [Display(Name = "List Price")]
        [Range(1, 1000)]
        public double Price { get; set; }



    }
}

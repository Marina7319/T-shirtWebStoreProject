using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace T_shirtWebStore.Models
{
    public class Category
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Category Order")]
        public int DisplayOrder { get; set; }
    }
}

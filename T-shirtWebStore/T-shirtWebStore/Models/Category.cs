using System.ComponentModel.DataAnnotations;

namespace T_shirtWebStore.Models
{
    public class Category
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}

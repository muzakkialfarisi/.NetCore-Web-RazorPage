using System.ComponentModel.DataAnnotations;

namespace WebApp1.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Display Order")]
        public string DisplayOrder { get; set; }
    }
}

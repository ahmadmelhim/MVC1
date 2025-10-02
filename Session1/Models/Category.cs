using System.ComponentModel.DataAnnotations;

namespace Session1.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Please enter the category name.")]
        [MinLength(3,ErrorMessage = "Category name must be at least 3 characters long.")]
        [MaxLength(15,ErrorMessage = "Category name cannot exceed 15 characters.")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}

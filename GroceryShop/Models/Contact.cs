using System.ComponentModel.DataAnnotations;

namespace GroceryShop.Models
{
    public class Contact
    {
        [Key]
        public int id { get; set; }

        [Required]  
        public string Name { get; set; }
        [Required]  
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }


        [Required]  
        public string Message { get; set; }

    }
}

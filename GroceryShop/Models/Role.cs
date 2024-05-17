using System.ComponentModel.DataAnnotations;

namespace GroceryShop.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string email { get; set; }

        public string role { get; set; }

    }
}

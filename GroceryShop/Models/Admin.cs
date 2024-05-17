using System.ComponentModel.DataAnnotations;

namespace GroceryShop.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public string password { get; set;}
    }
}

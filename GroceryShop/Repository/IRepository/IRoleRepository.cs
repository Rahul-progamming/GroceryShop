using GroceryShop.Models;

namespace GroceryShop.Repository.IRepository
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetbyEmail(string email);
    }
}
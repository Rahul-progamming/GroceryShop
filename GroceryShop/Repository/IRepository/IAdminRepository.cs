
using GroceryShop.Models;

namespace GroceryShop.Repository.IRepository
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Admin GetByEmail(string email);
    }
}

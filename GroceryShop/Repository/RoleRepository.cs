using GroceryShop.Data;
using GroceryShop.Models;
using GroceryShop.Repository.IRepository;

namespace GroceryShop.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private readonly ApplicationDbContaxt db;
        public RoleRepository(ApplicationDbContaxt db) : base(db)
        {
            this.db = db;
        }

        public Role GetbyEmail(string email)
        {
            return db.Roles.FirstOrDefault(q => q.email == email);
        }
    }
}

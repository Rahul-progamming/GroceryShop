using GroceryShop.Data;
using GroceryShop.Models;
using GroceryShop.Repository.IRepository;

namespace GroceryShop.Repository
{
    public class AdminRepository : Repository<Admin> ,IAdminRepository
    {
        private readonly ApplicationDbContaxt db;
        public AdminRepository(ApplicationDbContaxt db):base(db)
        {
            this.db = db;
        }

      

        public object SingleOrDefault()
        {
            return db.Admins.SingleOrDefault();
        }

        public Admin GetByEmail(string email)
        {
            return db.Admins.FirstOrDefault(e => e.email == email);
        }
    }
}

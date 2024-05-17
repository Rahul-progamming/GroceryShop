using GroceryShop.Data;
using GroceryShop.Repository.IRepository;

namespace GroceryShop.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly ApplicationDbContaxt db;
        public IContactRepository Contact {  get; set; }

        public IAdminRepository Admin {get; set;}

        public IRoleRepository Role {get; set;}

        public UnitOfWorks(ApplicationDbContaxt db)
        {
            this.db = db;
            Contact = new ContactRepository(db);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}

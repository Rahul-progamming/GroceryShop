using GroceryShop.Data;
using GroceryShop.Models;
using GroceryShop.Repository.IRepository;

namespace GroceryShop.Repository
{
    internal class ContactRepository : Repository<Contact>, IContactRepository
    {
        private ApplicationDbContaxt db;

        public ContactRepository(ApplicationDbContaxt db) :base(db) 
        {
            this.db = db;
        }

        public Contact GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> Search(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact obj)
        {
            throw new NotImplementedException();
        }
    }
}
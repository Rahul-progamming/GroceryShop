namespace GroceryShop.Repository.IRepository
{
    public interface IUnitOfWorks
    {
        IContactRepository Contact { get; }

        IAdminRepository Admin { get; }

        IRoleRepository Role { get; }
        public void Save();
    }
}

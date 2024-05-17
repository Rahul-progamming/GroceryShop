using GroceryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryShop.Data
{
    public class ApplicationDbContaxt : DbContext
    {
        public ApplicationDbContaxt(DbContextOptions<ApplicationDbContaxt> options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Role> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin { Id = 1, Name = "Rahul", email = "rahul@gmail.com", password = "Admin@123" });

            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "Rahul", email = "rahul@gmail.com", role = "Admin" });
        }
    }
}

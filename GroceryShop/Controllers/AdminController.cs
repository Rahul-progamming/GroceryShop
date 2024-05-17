using GroceryShop.Data;
using GroceryShop.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShop.Controllers
{
    public class AdminController : Controller
    {
      //  private readonly UnitOfWorks _unitOfWorks;
        private readonly ApplicationDbContaxt _db;
        public AdminController(ApplicationDbContaxt db)
        {
            //       this._unitOfWorks = unitOfWorks;
            _db = db;
        }
        public IActionResult DashBoard()
        {
            return View();
        }

        public IActionResult contact()
        {
            var contact=_db.Contacts.ToList();  

            return View(contact);
        }

    }
}

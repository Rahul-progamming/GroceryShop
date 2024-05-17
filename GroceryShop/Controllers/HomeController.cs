using GroceryShop.Models;
using GroceryShop.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GroceryShop.Controllers
{

    
    public class HomeController : Controller
    {

        private readonly IUnitOfWorks unitOfWorks;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IUnitOfWorks unitOfWorks)
        {
            this.unitOfWorks = unitOfWorks; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (contact != null)
            {
                unitOfWorks.Contact.Add(contact);
                unitOfWorks.Save();
                return RedirectToAction("Index");    
            }
            return View();  
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

    }
}

using GroceryShop.Models.VMModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using GroceryShop.Data;
using GroceryShop.Repository;
using System.Reflection.Metadata.Ecma335;

namespace GroceryShop.Controllers
{

    public class LoginController : Controller
    {
        //private readonly UnitOfWorks _unitOfWorks;
        private readonly ApplicationDbContaxt _db;
        public LoginController( ApplicationDbContaxt db)
        {
            //this._unitOfWorks = unitOfWorks;
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVm log)
        {
       //     var role = unitOfWorks.Role.GetbyEmail(r => r.email == log.Email)?.role;

            var role = _db.Roles.FirstOrDefault(r => r.email == log.email)?.role;
            if (role == "Admin")
            {
                var existingAdmin = _db.Admins.SingleOrDefault(u => u.email == log.email);

                if (existingAdmin != null && existingAdmin.password == log.password)
                {
                    //HttpContext.Session.SetInt32("AdminId", existingAdmin.Id);
                    //HttpContext.Session.SetString("AdminEmail", existingAdmin.email);

                    //var claims = new List<Claim>
                    //{
                    //        new Claim(ClaimTypes.Name, existingAdmin.Email)
                    //};

                    //-------------------------------------------------

                    //        var adminClaims = new List<Claim>
                    //            {
                    //new Claim(ClaimTypes.Name, existingAdmin.Email),
                    //// Add any additional claims specific to admin if needed
                    //            };

                    //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    //        var authProperties = new AuthenticationProperties();

                    //        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                    TempData["Success"] = "Login Successfully";
                    return RedirectToAction("DashBoard", "Admin");
                }
                
            }
            return View();
            //else if (role.role == "User")
            //{
            //    var existingUser = unitOfWorks.Users.SingleOrDefault(u => u.Email == vm.Email);

            //    if (existingUser != null && existingUser.IsActivated == false)
            //    {
            //        TempData["Error"] = "Not Authorized to Login !!!";
            //        return RedirectToAction("Login", "Login");
            //    }

            //    if (existingUser != null && existingUser.Password == vm.Password)
            //    {
            //        HttpContext.Session.SetInt32("UserId", existingUser.Id);
            //        HttpContext.Session.SetString("UserEmail", existingUser.Email);
            //        HttpContext.Session.SetString("UserName", existingUser.Name);

            //var claims = new List<Claim>
            //{
            //        new Claim(ClaimTypes.Name, existingUser.Email)
            //};

            //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //var authProperties = new AuthenticationProperties();

            //HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

            //            TempData["Success"] = "Login Successfully";
            //            return RedirectToAction("Index", "Home");
            //        }
            //    }

            //    TempData["Error"] = "Login Failed: Invalid Credentials";
            //    return RedirectToAction("Login", "Login");
            //}
            //    return View();  

            //}
        }
        
    }
    
}

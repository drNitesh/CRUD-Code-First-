using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    
    public class UserRegistationController : Controller
    {
        public readonly UserDbContext _userDbContext;
        public UserRegistationController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        
        public IActionResult UserRegistration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegistration(CodeFirst.Models.UserRegistration userRegistration)
        {
            if (userRegistration != null)
            {

                _userDbContext.Add(userRegistration);
                _userDbContext.SaveChanges();
                    return RedirectToAction("UserLogin", "UserLogin");
                
            }
            else
            {
                return View();
            }
        }
    }
}
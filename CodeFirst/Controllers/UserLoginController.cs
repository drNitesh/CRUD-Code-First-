using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    public class UserLoginController : Controller
    {
        public readonly UserDbContext _userDbContext;
        public UserLoginController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(CodeFirst.Models.UserLogin l)
        {
            if (l != null)
            {
                _userDbContext.Add(l);
                _userDbContext.SaveChanges();
                    return RedirectToAction("UserProfile", "UserProfile");
             }
                
            else

                return View();
        }
    }
}


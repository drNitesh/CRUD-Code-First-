using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    public class UserProfileController : Controller
    {
        public readonly UserDbContext _userDbContext;
        public UserProfileController(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public IActionResult UserProfile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserProfile(CodeFirst.Models.UserProfile userProfile)
        {
            if (userProfile != null)
            {

                _userDbContext.Add(userProfile);
                _userDbContext.SaveChanges();
                return RedirectToAction("Index","UserSummary");
            }
            else

                return View();

        }
    }
}
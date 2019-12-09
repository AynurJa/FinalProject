using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicHome.DAL;
using MagicHome.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicHome.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public UserController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserId = user.Id;
            ViewBag.TotalCount = _context.Adverts.Where(m => m.UserId == user.Id).Count();
            return View(_context.Adverts.Where(m => m.UserId == user.Id.ToString() && m.User.Status == false).OrderByDescending(m => m.CreateAt).Take(3).ToList());

        }


        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            var ruser = await _userManager.FindByNameAsync(User.Identity.Name);
            var userrr = _context.Adverts.Find(id);
            if (userrr == null) return NotFound();
            if (userrr.UserId != ruser.Id.ToString()) return NotFound();

            return View(userrr);
        }

        
        public IActionResult Privacy()
        {
            if (!User.Identity.IsAuthenticated)
            {
             return Redirect("/Account/Login");
            }

            return View();

        }
        //[HttpPost]
        //public async Task<IActionResult> Privacy(string oldpass, string newpass, string confpass, string accblock)

        //{

        //    if (newpass != confpass)
        //    {
        //        ModelState.AddModelError("confpass", "Parollar uygun deyil");
        //        //return View(//modeli qoy)
        //    }

        //    var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);



        //    //var newPassword=_userManager.PasswordHasher.HashPassword(currentUser,newpass);



        //    //return Content(mydata.ToString());


        ////}
    }
}

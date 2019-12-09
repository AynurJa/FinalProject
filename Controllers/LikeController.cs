using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicHome.DAL;
using MagicHome.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MagicHome.Controllers
{
    public class LikeController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public LikeController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


       
        public async Task<JsonResult> Index(int itemId)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var hasLikedBefore = _context.Likes.FirstOrDefault(m => m.AdvertId == itemId && m.UserId == user.Id);

            if (hasLikedBefore != null)
            {
                _context.Likes.Remove(hasLikedBefore);
                _context.SaveChanges();
                return Json("unliked");
            }

            Like like = new Like
            {
                UserId = user.Id,
                AdvertId = itemId
            };
            _context.Likes.Add(like);
            _context.SaveChanges();
            
            return Json("liked");
        }
    }
}
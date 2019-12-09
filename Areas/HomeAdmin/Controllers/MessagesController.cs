using MagicHome.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MagicHome.Areas.HomeAdmin.Controllers
{
    public class MessagesController : Controller
    {
        private readonly AppDbContext _context;

        public MessagesController(AppDbContext _context)
        {
            this._context = _context;
        }

        [Area("HomeAdmin")]
        public IActionResult Index()
        {
            var allMessages = _context.Messages.OrderByDescending(m=>m.IsRead).ToList();
            return View(allMessages);
        }

        public JsonResult MarkAsRead(int messageId)
        {
            var message = _context.Messages.Find(messageId);
            message.IsRead = true;
            _context.SaveChanges();

            return Json("ok");
        }
    }
}
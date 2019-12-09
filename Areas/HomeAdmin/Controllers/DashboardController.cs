using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MagicHome.Areas.HomeAdmin.Controllers
{
    [Area("HomeAdmin")]
    public class DashboardController : Controller
    {
        public async Task<IActionResult> Index()
        {           
            return View();
        }
    }
}
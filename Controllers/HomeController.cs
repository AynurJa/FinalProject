using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MagicHome.Models;
using MagicHome.DAL;
using MagicHome.ViewModel;
using Microsoft.AspNetCore.Authorization;
using  MagicHome.Utilities;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MagicHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {


            HomeVM vm = new HomeVM
            {

                aNewHome = _context.Adverts.Where(m => m.User.Status == false).OrderByDescending(m => m.CreateAt).Take(15).ToList(),
                aVip = _context.Adverts.Where(m => m.User.Status == false && m.IsVip == true).OrderByDescending(m => m.CreateAt).ToList(),
                aRent = _context.Adverts.Where(m => m.User.Status == false && m.AdvertType.SaleType == "Rent").OrderByDescending(m => m.IsVip).ThenByDescending(m => m.CreateAt).ToList(),
                aSale= _context.Adverts.Where(m=>m.User.Status==false && m.AdvertType.SaleType=="Sale").OrderByDescending(m=> m.IsVip).ThenByDescending(m=> m.CreateAt).ToList(),
                aPrice=_context.Adverts.Where(m=>m.User.Status==false && m.Price <=700000).OrderBy(m=>m.Price).ToList()

               
            };

            //vm.LikeIdList.Add();

            return View(vm);
           
        }
       


        public IActionResult  About()
        {
            return View();
        }


       

        [HttpPost]
        public async Task<IActionResult> lform(Message message)
        {
            message.IsRead = false;
            message.CreateTime = DateTime.Now;

            if(!ModelState.IsValid)
            {
                var errorMessage = ModelState.Values
                    .Where(m => m.ValidationState == ModelValidationState.Invalid)
                    .FirstOrDefault()
                    .Errors;

                return Json(new { status = "400", errorMessage });


                //burda iflerle yoxlayib demelisen ki meselcun name bosudusa return json name duz yazin zehmet olmasa

            // yeqin yolchu muellim onu deyir

            
            }


            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return Json(new { status = "200", data = Url.Action("Index", "Home") });


        }


        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page";
            return View();
        }


        


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]



    }
}

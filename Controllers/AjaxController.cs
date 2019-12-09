using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using MagicHome.DAL;
using MagicHome.Models;
using MagicHome.ViewModel.RequestModels;
using Microsoft.AspNetCore.Identity;

namespace MagicHome.Controllers
{
    public class AjaxController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public AjaxController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
      
        

        public IActionResult SearchButton(AdvertSearchInputModel model)
        {
            AdvertSearchOutputModel outputModel = new AdvertSearchOutputModel();
            outputModel.CustomErrorMessage = new List<string>();

            if (string.IsNullOrEmpty(model.SearchKey) 
                || !model.CategoryId.HasValue)
                outputModel.CustomErrorMessage.Add("Some required filter fields are empty!");

            if(model.FromPrice > model.ToPrice)
                outputModel.CustomErrorMessage.Add("Min-Price is bigger than Max-Price!");

            if(outputModel?.CustomErrorMessage.Count > 0)
            {
                outputModel.HasError = true;
                return PartialView("_SearchPartialView", outputModel);
            }

            var searchResult = _context.Adverts.Where(x => 
                                                        x.City.CityName.ToLower().Contains(model.SearchKey.ToLower())
                                                        && x.AdvertTypeId > 0
                                                        && !x.User.Status)
                                                        .OrderByDescending(m => m.IsVip)
                                                        .ToList();
            if (model.ToPrice > 0)
                searchResult = searchResult.Where(x => x.Price <= model.ToPrice).ToList();

            if (model.FromPrice > 0)
                searchResult = searchResult.Where(x => x.Price >= model.FromPrice).ToList();

            outputModel.SearchResult = searchResult;

            return PartialView("_SearchPartialView", outputModel);
        }
        
        public IActionResult LoadRent(int p)
        {
            var lorent = _context.Adverts.OrderByDescending(m => m.CreateAt).Where(m => m.AdvertTypeId == 2 && m.User.Status == false).Skip((p*3)).Take(3).ToList();

            if (lorent != null)
            {
                return PartialView("_RentLoadPartialView", lorent);
            }
            else
            {
                return View();
            }

        }
        
        public IActionResult LoadSale(int a)
        {
            var lorent = _context.Adverts.OrderByDescending(m => m.CreateAt).Where(m => m.AdvertTypeId == 1 && m.User.Status == false).Skip((a * 3)).Take(3).ToList();

            if (lorent != null)
            {
                return PartialView("_SaleLoadPartialView", lorent);
            }
            else
            {
                return View();
            }

        }
        
        public IActionResult LoadMore(int userid,int page = 3)
        {


            var user =  _userManager.FindByNameAsync(User.Identity.Name);
            if (userid != user.Id) return NotFound();
            var loadinfo = _context.Adverts.OrderByDescending(m => m.CreateAt).Where( m =>m.UserId == userid.ToString()).Skip(page).Take(3).ToList();
            if(loadinfo !=null)
            {
                return PartialView("__LoadMore", loadinfo);

            }
            return Content("");


        }

        public async Task<IActionResult> DeletAdvert(int? deleteid)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (deleteid == null) return Json(new { status = "400" });
            var delitem = _context.Adverts.Find(deleteid);
            if(delitem ==null) return Json(new { status = "400" });
            if (delitem.UserId != user.Id.ToString()) return Json(new { status = "400" });
            FileExtensions.FileExtensions.RemoveImage("~/Images", delitem.Image);
            _context.Adverts.Remove(delitem);
            await _context.SaveChangesAsync();
            return Json(new { status = "200", data = Url.Action("Index", "User") });

        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicHome.DAL;
using MagicHome.Models;
using MagicHome.ViewModel;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MagicHome.FileExtensions;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MagicHome.Controllers
{
  
    public class AdvertController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<User> _userManager;
        public AdvertController(AppDbContext context, IHostingEnvironment hosting, UserManager<User> userManager)
        {
            _context = context;
            _hosting = hosting;
            _userManager = userManager;
        }


        [AllowAnonymous]
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var AdvertPart = _context.Adverts.Find(id);
            if (AdvertPart == null) return NotFound();
            AdvertPartVW newvm = new AdvertPartVW()
           {
                Adverts = _context.Adverts.Where(m => m.User.Status == false && m.CityId == AdvertPart.Id && m.Id != AdvertPart.Id).OrderByDescending(m => m.IsVip == true).ThenBy(m => m.CreateAt).ToList(),
                AdvertPart = AdvertPart
            };
            return View(newvm);
        }


        [AllowAnonymous]
        public IActionResult Rent()
        {
            //ViewBag.TotalSaleCount = _context.Adverts.Where(m => m.AdvertTypeId == 2 && m.User.Status == false).Count();
            //var adverttable = _context.Adverts.ToList();

            //var asdasd = _context.Adverts.FirstOrDefault();
            var rentt = _context.Adverts.Where(m => m.AdvertTypeId == 2 && m.User.Status == false).OrderByDescending(m => m.CreateAt).Take(6).ToList();
            ViewBag.TotalRentCount = _context.Adverts.Where(m => m.AdvertTypeId == 2 && m.User.Status == false).Count();
            return View(rentt);
        }

        [AllowAnonymous]
        public IActionResult Sale()
        {
            var salle = _context.Adverts.Where(m => m.AdvertTypeId == 1 && m.User.Status == false).OrderByDescending(m => m.CreateAt).Take(3).ToList();
            ViewBag.TotalRentCount = _context.Adverts.Where(m => m.AdvertTypeId == 2 && m.User.Status == false).Count();
            return View(salle);
        }


        [Authorize]
        public IActionResult Create()
        {
            ViewBag.AdvertType = _context.AdvertTypes.ToList();
            ViewBag.Cities = _context.Cities.ToList();
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Price,RoomCount,BedRoom,BathRoom,RoomArea,CreatedAt,Description,IsVip,IsNew,Photo,AdvertTypeId,UserId,CityId,Address")]Advert advert)
        {
            string fileName = null;
            try
            {
                ViewBag.AdvertType = _context.AdvertTypes.ToList();
                ViewBag.Cities = _context.Cities.ToList();
                var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (!ModelState.IsValid) return View(advert);
                if (!advert.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Enter Photo please !");
                    return View(advert);
                }
                if (advert.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Enter Photo please!");
                    return View(advert);
                }
                if (!advert.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "File type should be image");
                    return View();
                }
                if (advert.Photo.Length / 1024 / 1024 > 2)
                {
                    ModelState.AddModelError("Photo", "Image size can not be more than 2 mb");
                    return View();
                }



                string path = _hosting.WebRootPath;
                fileName = Path.Combine("newpic", Guid.NewGuid().ToString() + advert.Photo.FileName);
                string resultPath = Path.Combine(path, "images", fileName);
                using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
                {
                    await advert.Photo.CopyToAsync(fileStream);
                }
                advert.Image = fileName;
                advert.CreateAt = DateTime.Now;
                advert.UserId = currentUser.Id;
                await _context.Adverts.AddAsync(advert);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                FileExtensions.FileExtensions.RemoveImage(_hosting.WebRootPath, fileName);
            }


            
           
            return RedirectToAction("Index", "User");
        }



        public async Task<IActionResult> Edit(int ? id)
        {
            ViewBag.Cities = _context.Cities.ToList();
            ViewBag.RentType = _context.AdvertTypes.ToList();
            if (id == null) return NotFound();
            var edits = _context.Adverts.Find(id);
            var dbuser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (edits == null) return NotFound();
            if (edits.UserId != dbuser.Id.ToString()) return NotFound();
            return View(edits);
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Price,RoomCount,BedRoom,BathRoom,RoomArea,CreatedAt,Description,IsVip,IsNew,Photo,AdvertTypeId,UserId,CityId,Address")]Advert advert)
        {
            string aynew = null;
            try
            {
                ViewBag.AdvertType = _context.AdvertTypes.ToList();
                ViewBag.Cities = _context.Cities.ToList();
                var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (!ModelState.IsValid) return View(advert);
                if (!advert.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Enter Photo please !");
                    return View(advert);
                }
                if (advert.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Enter Photo please!");
                    return View(advert);
                }
                if (!advert.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "File type should be image");
                    return View();
                }
                if (advert.Photo.Length / 1024 / 1024 > 2)
                {
                    ModelState.AddModelError("Photo", "Image size can not be more than 2 mb");
                    return View();
                }



                string path = _hosting.WebRootPath;
                aynew = Path.Combine("newpic", Guid.NewGuid().ToString() + advert.Photo.FileName);
                string resultPath = Path.Combine(path, "images", aynew);
                using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
                {
                    await advert.Photo.CopyToAsync(fileStream);
                }
                advert.Image = aynew;
                advert.CreateAt = DateTime.Now;
                advert.UserId = currentUser.Id;
                await _context.Adverts.AddAsync(advert);
                _context.Entry(advert).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch
            {
                FileExtensions.FileExtensions.RemoveImage(_hosting.WebRootPath, aynew);

            }
            return RedirectToAction("Edit", "Advert");






        }




}



}

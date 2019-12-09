using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicHome.DAL;
using MagicHome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MagicHome.Models;
using static MagicHome.Utilities.SD;

namespace MagicHome.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(AppDbContext context, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)

        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

        }

        public IActionResult Register()
        {
            var mysessionuser = _userManager.FindByNameAsync(User.Identity.Name);

            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);

            User NewUser = new User
            {
                firstname = registerViewModel.FirstName,
                lastname = registerViewModel.LastName,
                Email = registerViewModel.Email,
                PhoneNumber = registerViewModel.PhoneNumber,
                UserName = registerViewModel.UserName

            };
            IdentityResult identityResult = await _userManager.CreateAsync(NewUser, registerViewModel.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerViewModel);
            }


            //add default member role to user

            await _userManager.AddToRoleAsync(NewUser, Roles.Member.ToString());

            await _signInManager.SignInAsync(NewUser, true);

            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }




        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LogInViewModel logInViewModel)
        {
            if (!ModelState.IsValid) return View(logInViewModel);
            User user = await _userManager.FindByEmailAsync(logInViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or Password is invalid");
                return View(logInViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, logInViewModel.Password, logInViewModel.RememberMe, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is invalid");
                return View(logInViewModel);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        public async Task OurRoles()
        {
            if (!await _roleManager.RoleExistsAsync(Roles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Roles.Manager.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.Manager.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Roles.Member.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Roles.Member.ToString()));
            }
        }

    }
}
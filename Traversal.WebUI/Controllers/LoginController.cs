using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrete;
using Traversal.WebUI.Models;

namespace Traversal.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel registerModel)
        {
            AppUser appUser = new AppUser()
            {
                Name = registerModel.Name,
                Surname = registerModel.Surname,
                Email = registerModel.Mail,
                UserName = registerModel.Username
            };

            if (registerModel.Password == registerModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, registerModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(registerModel);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}

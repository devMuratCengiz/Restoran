using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restoran.Entity.Entities;
using Restoran.WebUI.Models;

namespace Restoran.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Index(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid) 
            {
                AppUser user = new AppUser()
                {
                    Email = registerViewModel.Mail,
                    UserName = registerViewModel.Username,
                    NameSurname = registerViewModel.NameSurname
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(registerViewModel);
        }
    }
}

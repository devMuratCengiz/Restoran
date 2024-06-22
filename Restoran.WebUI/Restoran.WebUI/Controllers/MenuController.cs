using Microsoft.AspNetCore.Mvc;

namespace Restoran.WebUI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

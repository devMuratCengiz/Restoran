using Microsoft.AspNetCore.Mvc;

namespace Restoran.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

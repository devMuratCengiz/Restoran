using Microsoft.AspNetCore.Mvc;

namespace Restoran.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

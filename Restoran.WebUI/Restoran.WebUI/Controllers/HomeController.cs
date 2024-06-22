using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Restoran.WebUI.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Restoran.WebUI.Controllers
{
    public class TeamMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

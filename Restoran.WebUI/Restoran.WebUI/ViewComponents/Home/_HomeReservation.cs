using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.ViewComponents.Home
{
    public class _HomeReservation : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View();
        }
    }
}

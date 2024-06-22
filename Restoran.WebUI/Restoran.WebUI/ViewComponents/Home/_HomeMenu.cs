using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.BannerDtos;
using Restoran.WebUI.DTOs.MenuDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.ViewComponents.Home
{
    public class _HomeMenu : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultMenuDto>>("menus");
            return View(values);
        }
    }
}

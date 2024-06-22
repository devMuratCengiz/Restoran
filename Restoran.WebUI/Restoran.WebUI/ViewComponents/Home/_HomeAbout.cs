using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.AboutDtos;
using Restoran.WebUI.DTOs.BannerDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.ViewComponents.Home
{
    public class _HomeAbout : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
            return View(values);
        }
    }
}

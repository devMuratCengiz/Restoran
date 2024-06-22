using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.BannerDtos;
using Restoran.WebUI.DTOs.ServiceDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.ViewComponents.Home
{
    public class _HomeService : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultServiceDto>>("services");
            return View(values);
        }
    }
}

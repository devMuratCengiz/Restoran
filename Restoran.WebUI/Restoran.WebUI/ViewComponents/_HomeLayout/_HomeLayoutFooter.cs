using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.AboutDtos;
using Restoran.WebUI.DTOs.FooterDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.ViewComponents._HomeLayout
{
    public class _HomeLayoutFooter : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultFooterDto>>("footers");
            return View(values);
        }
    }
}

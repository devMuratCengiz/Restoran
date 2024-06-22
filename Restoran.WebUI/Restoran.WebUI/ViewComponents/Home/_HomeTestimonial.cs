using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.ServiceDtos;
using Restoran.WebUI.DTOs.TestimonialDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.ViewComponents.Home
{
    public class _HomeTestimonial : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("testimonials");
            return View(values);
        }
    }
}

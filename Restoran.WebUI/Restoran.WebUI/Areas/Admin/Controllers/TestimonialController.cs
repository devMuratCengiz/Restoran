using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.TestimonialDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTestimonialDto>>("Testimonials");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"Testimonials/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto createTestimonialDto)
        {
            var value = await _client.PostAsJsonAsync("Testimonials", createTestimonialDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateTestimonialDto>($"Testimonials/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateTestimonialDto updateTestimonialDto)
        {
            await _client.PutAsJsonAsync("Testimonials", updateTestimonialDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

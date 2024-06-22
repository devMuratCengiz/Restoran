using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.AboutDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("Abouts");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"Abouts/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutDto createAboutDto)
        {
            var value = await _client.PostAsJsonAsync("Abouts", createAboutDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateAboutDto>($"Abouts/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAboutDto updateAboutDto)
        {
            await _client.PutAsJsonAsync("Abouts", updateAboutDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.BannerDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BannerController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBannerDto>>("Banners");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"Banners/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBannerDto createBannerDto)
        {
            var value = await _client.PostAsJsonAsync("Banners", createBannerDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateBannerDto>($"Banners/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBannerDto updateBannerDto)
        {
            await _client.PutAsJsonAsync("Banners", updateBannerDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

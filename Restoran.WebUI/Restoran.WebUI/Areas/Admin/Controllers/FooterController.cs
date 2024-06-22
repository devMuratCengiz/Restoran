using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.FooterDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class FooterController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultFooterDto>>("Footers");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"Footers/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateFooterDto createFooterDto)
        {
            var value = await _client.PostAsJsonAsync("Footers", createFooterDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateFooterDto>($"Footers/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateFooterDto updateFooterDto)
        {
            await _client.PutAsJsonAsync("Footers", updateFooterDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

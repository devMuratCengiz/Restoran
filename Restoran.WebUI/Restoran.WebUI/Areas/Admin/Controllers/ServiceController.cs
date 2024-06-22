using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.ServiceDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultServiceDto>>("Services");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"Services/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceDto createServiceDto)
        {
            var value = await _client.PostAsJsonAsync("Services", createServiceDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateServiceDto>($"Services/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateServiceDto updateServiceDto)
        {
            await _client.PutAsJsonAsync("Services", updateServiceDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

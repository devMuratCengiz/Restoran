using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.MenuDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MenuController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultMenuDto>>("Menus");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"Menus/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMenuDto createMenuDto)
        {
            var value = await _client.PostAsJsonAsync("Menus", createMenuDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateMenuDto>($"Menus/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateMenuDto updateMenuDto)
        {
            await _client.PutAsJsonAsync("Menus", updateMenuDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

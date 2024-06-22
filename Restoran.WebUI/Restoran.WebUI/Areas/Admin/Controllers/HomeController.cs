using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.ReservationDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task <IActionResult>Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultReservationDto>>("reservations");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"reservations/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateReservationDto createReservationDto)
        {
            var value = await _client.PostAsJsonAsync("reservations",createReservationDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateReservationDto>($"reservations/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateReservationDto updateReservationDto)
        {
            await _client.PutAsJsonAsync("reservations", updateReservationDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

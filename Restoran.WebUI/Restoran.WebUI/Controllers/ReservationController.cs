using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.ReservationDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateReservationDto createReservationDto)
        {
            var response = await _client.PostAsJsonAsync("reservations", createReservationDto);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Rezervasyon başarıyla oluşturuldu!";
            }
            else
            {
                TempData["ErrorMessage"] = "Rezervasyon oluşturulamadı. Daha sonra tekrar deneyiniz.";
            }

            return RedirectToAction("Index","Home");
        }

       
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.TeamMemberDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeamMemberController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTeamMemberDto>>("TeamMembers");
            return View(values);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteAsync($"TeamMembers/{id}");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamMemberDto createTeamMemberDto)
        {
            var value = await _client.PostAsJsonAsync("TeamMembers", createTeamMemberDto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int id)
        {
            var value = await _client.GetFromJsonAsync<UpdateTeamMemberDto>($"TeamMembers/{id}");
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateTeamMemberDto updateTeamMemberDto)
        {
            await _client.PutAsJsonAsync("TeamMembers", updateTeamMemberDto);
            return RedirectToAction(nameof(Index));
        }
    }
}

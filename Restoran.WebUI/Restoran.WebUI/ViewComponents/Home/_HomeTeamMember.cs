using Microsoft.AspNetCore.Mvc;
using Restoran.WebUI.DTOs.ServiceDtos;
using Restoran.WebUI.DTOs.TeamMemberDtos;
using Restoran.WebUI.Helpers;

namespace Restoran.WebUI.ViewComponents.Home
{
    public class _HomeTeamMember : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultTeamMemberDto>>("teammembers");
            return View(values);
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Business.Abstract;
using Restoran.DTO.Dtos.TeamMemberDtos;
using Restoran.Entity.Entities;

namespace Restoran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController(IGenericService<TeamMember> _service, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.TGetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.TGetById(id));
        }
        [HttpPost]
        public IActionResult Create(CreateTeamMemberDto createTeamMemberDto)
        {
            var value = _mapper.Map<TeamMember>(createTeamMemberDto);
            _service.TCreate(value);
            return Ok("Created");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.TDelete(id);
            return Ok("Deleted");
        }
        [HttpPut]
        public IActionResult Update(UpdateTeamMemberDto updateTeamMemberDto)
        {
            var value = _mapper.Map<TeamMember>(updateTeamMemberDto);
            _service.TUpdate(value);
            return Ok("Updated");
        }
    }
}

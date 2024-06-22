using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Business.Abstract;
using Restoran.DTO.Dtos.BannerDtos;
using Restoran.Entity.Entities;

namespace Restoran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _service, IMapper _mapper) : ControllerBase
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
        public IActionResult Create(CreateBannerDto createBannerDto)
        {
            var value = _mapper.Map<Banner>(createBannerDto);
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
        public IActionResult Update(UpdateBannerDto updateBannerDto)
        {
            var value = _mapper.Map<Banner>(updateBannerDto);
            _service.TUpdate(value);
            return Ok("Updated");
        }
    }
}

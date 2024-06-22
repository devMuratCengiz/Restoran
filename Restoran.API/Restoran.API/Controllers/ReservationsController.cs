using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Business.Abstract;
using Restoran.DTO.Dtos.ReservationDtos;
using Restoran.Entity.Entities;

namespace Restoran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController(IGenericService<Reservation> _service, IMapper _mapper) : ControllerBase
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
        public IActionResult Create(CreateReservationDto createReservationDto)
        {
            var value = _mapper.Map<Reservation>(createReservationDto);
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
        public IActionResult Update(UpdateReservationDto updateReservationDto)
        {
            var value = _mapper.Map<Reservation>(updateReservationDto);
            _service.TUpdate(value);
            return Ok("Updated");
        }
    }
}

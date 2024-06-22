using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran.Business.Abstract;
using Restoran.DTO.Dtos.TestimonialDtos;
using Restoran.Entity.Entities;

namespace Restoran.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _service, IMapper _mapper) : ControllerBase
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
        public IActionResult Create(CreateTestimonialDto createTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDto);
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
        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            _service.TUpdate(value);
            return Ok("Updated");
        }
    }
}

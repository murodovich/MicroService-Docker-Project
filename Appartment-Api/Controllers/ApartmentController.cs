
using Appartment_Application.Repositories.ApartmentRepositories;
using Appartment_Domain.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appartment_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentRepository _repository;

        public ApartmentController(IApartmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ApartmentGetAll()
        {
            var result = _repository.GetAllAsync();
            return Ok(result.Result);

        }

        [HttpPost]
        public IActionResult ApartmentCreat(ApartmentDto dto)
        {
            var result = _repository.CreateAsync(dto);
            return Ok(result.Result);
        }



        [HttpGet]
        public IActionResult ApartmentGetById(int id)
        {
            var result = _repository.GetByIdAsync(id);
            return Ok(result.Result);
        }

        [HttpPut]
        public IActionResult ApartmentUpdate(int id, ApartmentDto dto)
        {
            var result = _repository.UpdateAsync(id, dto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult ApartmentDeleted(int id)
        {
            var result = _repository.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}

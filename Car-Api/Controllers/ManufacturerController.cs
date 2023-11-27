using Car_Application.Repositories.ManufacturerRepositories;
using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerController(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }
        [HttpGet]
        public IActionResult ManufacturerGetAll()
        {
            var result = _manufacturerRepository.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult ManufacturerCreated(ManufacturerDto manufacturerDto)
        {
            var result = _manufacturerRepository.CreateAsync(manufacturerDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult ManufacturerGetById(int id)
        {
            var result = _manufacturerRepository.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult ManufacturerUpdated(int id, ManufacturerDto manufacturerDto)
        {
            var result  = _manufacturerRepository.UpdateAsync(id, manufacturerDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult ManufacturerDeleted(int id)
        {
            var result = _manufacturerRepository.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}

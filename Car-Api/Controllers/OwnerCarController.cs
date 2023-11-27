using Car_Application.Repositories.OwnerCarRepositories;
using Car_Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Car_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OwnerCarController : ControllerBase
    {
        private readonly IOwnerCarRepository _ownerCarRepository;

        public OwnerCarController(IOwnerCarRepository ownerCarRepository)
        {
            _ownerCarRepository = ownerCarRepository;
        }

        [HttpGet]
        public IActionResult OwnerCarGetAll() 
        { 
            var result = _ownerCarRepository.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult OwnerCarCreated(OwnerCarDto ownerCarDto)
        {
            var result = _ownerCarRepository.CreateAsync(ownerCarDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult OwnerCarGetById(int id)
        {
            var result = _ownerCarRepository.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult OwnerCarUpdated(int id, OwnerCarDto ownerCarDto)
        {
            var result = _ownerCarRepository.UpdateAsync(id, ownerCarDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult OwnerCarDeleted(int id)
        {
            var result = _ownerCarRepository.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}

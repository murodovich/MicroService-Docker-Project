using Car_Application.Repositories.OwnerCarRepositories;
using Car_Application.Repositories.OwnerRepositories;
using Car_Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Car_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepo;

        public OwnerController(IOwnerRepository ownerRepo)
        {
            _ownerRepo = ownerRepo;
        }

        [HttpGet]
        public IActionResult OwnerGetAll()
        {
            var result = _ownerRepo.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult OwnerCreated(OwnerDto ownerDto)
        {
            var result = _ownerRepo.CreateAsync(ownerDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult OwnerGetById(int id)
        {
            var result = _ownerRepo.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult OwnerUpdated(int id, OwnerDto ownerDto)
        {
            var result = _ownerRepo.UpdateAsync(id, ownerDto);
            return Ok(result.Result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Tourism_Application.Dtos;
using Tourism_Application.Repositories.DestinationRepositories;
using Tourism_Infrastructure.Services.DestinationServices;

namespace Tourism_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        [HttpGet]
        public IActionResult DestinationGetAll()
        {
            var result = _destinationService.GetAll();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult DestinationCreate(DestinationDto destinationDto)
        {
            var result = _destinationService.Create(destinationDto);
            return Ok(result.Result);   
        }
        [HttpGet]
        public IActionResult DestinationGetById(int id)
        {
            var result = _destinationService.GetById(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult DestinationUpdate(int id, DestinationDto destinationDto)
        {
            var result = _destinationService.Update(id, destinationDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult DestinationDelete(int id)
        {
            var result = _destinationService.Delete(id);
            return Ok(result.Result);
        }
    }
}

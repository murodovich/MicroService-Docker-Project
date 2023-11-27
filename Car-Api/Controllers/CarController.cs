using Car_Application.Repositories.CarRepositories;
using Car_Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Car_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public IActionResult CarGetAll()
        {
            var result = _carRepository.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult CarCreated(CarDto carDto)
        {
            var result = _carRepository.CreateAsync(carDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult CarGetById(int id)
        {
            var result = _carRepository.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult CarUpdated(int id,CarDto carDto)
        {
            var result = _carRepository.UpdateAsync(id, carDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult CarDeleted(int id) 
        { 
            var result = _carRepository.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}

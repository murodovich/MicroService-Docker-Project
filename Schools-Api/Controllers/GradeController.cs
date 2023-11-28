using Microsoft.AspNetCore.Mvc;
using School_Application.Dtos;
using School_Application.Repositories.GradeRepositories;

namespace Schools_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeRepository _gradeRepository;

        public GradeController(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
        [HttpGet]
        public IActionResult GradeGetAll()
        {
            var result = _gradeRepository.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult GradeCreated(GradeDto dto)
        {
            var result = _gradeRepository.CreateAsync(dto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult GradeGetById(int id)
        {
            var result = _gradeRepository.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult GradeUpdated(int id, GradeDto dto)
        {
            var result = _gradeRepository.UpdateAsync(id, dto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult GradeDeleted(int id)
        {
            var result = _gradeRepository.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using School_Application.Dtos;
using School_Application.Repositories.CourseRepositories;

namespace Schools_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _coursRepo;

        public CourseController(ICourseRepository coursRepo)
        {
            _coursRepo = coursRepo;
        }

        [HttpGet]
        public IActionResult CourseGetAll()
        {
            var result = _coursRepo.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult CourseCreated(CourseDto course)
        {
            var result = _coursRepo.CreateAsync(course);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult CourseGetById(int id)
        {
            var result = _coursRepo.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult CourseUpdated(int id, CourseDto course)
        {
            var result = _coursRepo.UpdateAsync(id, course);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult CourseDeleted(int id)
        {
            var result = _coursRepo.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}

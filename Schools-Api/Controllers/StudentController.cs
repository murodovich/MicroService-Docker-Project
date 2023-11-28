using Microsoft.AspNetCore.Mvc;
using School_Application.Dtos;
using School_Application.Repositories.StudentRepositories;

namespace Schools_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public IActionResult StudentGetAll()
        {
            var result = _studentRepository.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult StudentCreated(StudentDto studentDto)
        {
            var result = _studentRepository.CreateAsync(studentDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult StudentGetById(int id)
        {
            var result = _studentRepository.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult StudentUpdated(int id, StudentDto studentDto)
        {
            var result = _studentRepository.UpdateAsync(id, studentDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult StudentDeleted(int id)
        {
            var result = _studentRepository.DeleteAsync(id);
            return Ok(result.Result);
        }
    }
}

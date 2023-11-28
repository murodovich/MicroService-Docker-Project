using Microsoft.AspNetCore.Mvc;
using School_Application.Dtos;
using School_Application.Repositories.EnrollmentRepositories;

namespace Schools_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpGet]
        public IActionResult EnrollmentGetAll()
        {
            var result = _enrollmentRepository.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult EnrollmentCreated(EnrollmentDto enrollmentDto)
        {
            var result = _enrollmentRepository.CreateAsync(enrollmentDto);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult EnrolmentGetById(int id)
        {
            var result = _enrollmentRepository.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult EnrollmentUpdated(int id, EnrollmentDto enrolmentDto)
        {
            var result = _enrollmentRepository.UpdateAsync(id, enrolmentDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult EnrollmentDeleted(int id)
        {
            var result = _enrollmentRepository.DeleteAsync(id);
            return Ok(result.Result);
        }

    }
}

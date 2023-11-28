using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.EnrollmentRepositories;
public interface IEnrollmentRepository :IBaseRepository<Enrollment,EnrollmentDto>
{
}

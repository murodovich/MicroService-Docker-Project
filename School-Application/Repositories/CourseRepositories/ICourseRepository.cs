using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.CourseRepositories;
public interface ICourseRepository : IBaseRepository<Course,CourseDto>
{
}

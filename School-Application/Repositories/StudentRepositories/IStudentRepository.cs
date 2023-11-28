using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.StudentRepositories;
public interface IStudentRepository : IBaseRepository<Student,StudentDto>
{
}

using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.GradeRepositories;
public interface IGradeRepository : IBaseRepository<Grade,GradeDto>
{
}

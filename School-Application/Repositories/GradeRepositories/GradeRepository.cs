using Microsoft.EntityFrameworkCore;
using School_Application.Data;
using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.GradeRepositories;
public class GradeRepository : IGradeRepository
{
    private readonly SchoolDBContext _dbContext;

    public GradeRepository(SchoolDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(GradeDto model)
    {
        Grade grade = new Grade();
        grade.StudentId = model.StudentId;
        grade.CourseId = model.CourseId;
        grade.GradeDate = model.GradeDate;
        grade.Score = model.Score;

        await _dbContext.Grades.AddAsync(grade);
        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result = await _dbContext.Grades.FirstOrDefaultAsync(x => x.GradeId == Id);

        _dbContext.Grades.Remove(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<Grade>> GetAllAsync()
    {
        var result = await _dbContext.Grades.ToListAsync();
        return result;
    }

    public async ValueTask<Grade> GetByIdAsync(int Id)
    {
        var result = await _dbContext.Grades.FirstOrDefaultAsync(x => x.GradeId == Id);
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, GradeDto model)
    {
        var result = await _dbContext.Grades.FirstOrDefaultAsync(x => x.GradeId == Id);

        result.StudentId = model.StudentId;
        result.CourseId = model.CourseId;
        result.GradeDate = model.GradeDate;
        result.Score = model.Score;

        _dbContext.Grades.Update(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }
}

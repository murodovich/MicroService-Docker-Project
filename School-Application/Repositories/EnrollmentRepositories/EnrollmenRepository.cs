using Microsoft.EntityFrameworkCore;
using School_Application.Data;
using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.EnrollmentRepositories;
public class EnrollmenRepository : IEnrollmentRepository
{
    private readonly SchoolDBContext _dbContext;

    public EnrollmenRepository(SchoolDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(EnrollmentDto model)
    {
        Enrollment enrollment = new Enrollment();
        enrollment.StudentId = model.StudentId;
        enrollment.CourseId = model.CourseId;
        enrollment.EnrollmentDate = model.EnrollmentDate;
        await _dbContext.Enrollments.AddAsync(enrollment);
        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result = await _dbContext.Enrollments.FirstOrDefaultAsync(x => x.EnrollmentId == Id);

        _dbContext.Enrollments.Remove(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<Enrollment>> GetAllAsync()
    {
        var result = await _dbContext.Enrollments.ToListAsync();
        return result;
    }

    public async ValueTask<Enrollment> GetByIdAsync(int Id)
    {
        var result = await _dbContext.Enrollments.FirstOrDefaultAsync(x => x.EnrollmentId == Id);
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, EnrollmentDto model)
    {
        var result = await _dbContext.Enrollments.FirstOrDefaultAsync(x => x.EnrollmentId == Id);
        result.StudentId = model.StudentId;
        result.CourseId = model.CourseId;
        result.EnrollmentDate = model.EnrollmentDate;

        _dbContext.Enrollments.Update(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }
}

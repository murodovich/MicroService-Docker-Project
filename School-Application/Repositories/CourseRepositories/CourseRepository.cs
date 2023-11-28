using Microsoft.EntityFrameworkCore;
using School_Application.Data;
using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.CourseRepositories;
public class CourseRepository : ICourseRepository
{
    private readonly SchoolDBContext _dbContext;

    public CourseRepository(SchoolDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(CourseDto model)
    {
        Course course = new Course();
        course.CourseName = model.CourseName;
        course.Credits = model.Credits;
        course.Instructor = model.Instructor;

        await _dbContext.Courses.AddAsync(course);
        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result =await _dbContext.Courses.FirstOrDefaultAsync(x => x.CourseId == Id);
        _dbContext.Courses.Remove(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<Course>> GetAllAsync()
    {
        var result = await _dbContext.Courses.ToListAsync();
        return result;
    }

    public async ValueTask<Course> GetByIdAsync(int Id)
    {
        var result = await _dbContext.Courses.FirstOrDefaultAsync(x => x.CourseId == Id);
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, CourseDto model)
    {
        var result = await _dbContext.Courses.FirstOrDefaultAsync(x => x.CourseId == Id);
        result.CourseName = model.CourseName;
        result.Credits = model.Credits;
        result.Instructor = model.Instructor;

        _dbContext.Courses.Update(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;

    }
}

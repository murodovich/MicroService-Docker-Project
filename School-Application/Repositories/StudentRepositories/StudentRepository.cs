using Microsoft.EntityFrameworkCore;
using School_Application.Data;
using School_Application.Dtos;
using School_Domain.Entities.Models;

namespace School_Application.Repositories.StudentRepositories;
public class StudentRepository : IStudentRepository
{
    private readonly SchoolDBContext _dbContext;

    public StudentRepository(SchoolDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(StudentDto model)
    {
        Student student = new Student();
        student.FirstName = model.FirstName;
        student.LastName = model.LastName;
        student.Age = model.Age;
        student.Group = model.Group;

        await _dbContext.Students.AddAsync(student);
        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result = await _dbContext.Students.FirstOrDefaultAsync(x => x.StudentId == Id);

        _dbContext.Students.Remove(result);
        var res  = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<Student>> GetAllAsync()
    {
        var result = await _dbContext.Students.ToListAsync();
        return result;
    }

    public async ValueTask<Student> GetByIdAsync(int Id)
    {
        var result = await _dbContext.Students.FirstOrDefaultAsync(x => x.StudentId == Id);
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, StudentDto model)
    {
        var result = await _dbContext.Students.FirstOrDefaultAsync(x => x.StudentId == Id);

        result.FirstName = model.FirstName;
        result.LastName = model.LastName;
        result.Age = model.Age;
        result.Group = model.Group;

        _dbContext.Students.Update(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }
}

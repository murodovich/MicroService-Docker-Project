using Appartment_Domain.Data;
using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Appartment_Application.Repositories.UserRepositories;
public class UserRepository : IUserRepository
{
    private readonly ApartmentDBContext _dbContext;

    public UserRepository(ApartmentDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(UserDto model)
    {

        User user = new User();
        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.Email = model.Email;
        user.Password = model.Password;

        await _dbContext.Users.AddAsync(user);
        var result = await _dbContext.SaveChangesAsync();
        return result;


    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        try
        {
            var result = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == Id);
            _dbContext.Users.Remove(result);
            var res = await _dbContext.SaveChangesAsync();
            return res;
        }
        catch (Exception ex)
        {
            return 0;
        }
    }

    public async ValueTask<List<User>> GetAllAsync()
    {
        try
        {
            var result = await _dbContext.Users.ToListAsync();
            return result;

        }
        catch (Exception ex)
        {
            return new List<User>();
        }
    }

    public async ValueTask<User> GetByIdAsync(int Id)
    {
        try
        {
            var result = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == Id);
            return result;

        }
        catch (Exception ex)
        {
            return new User();
        }
    }

    public async ValueTask<int> UpdateAsync(int Id, UserDto model)
    {
        try
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == Id);


            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.Password = model.Password;


            _dbContext.Users.Update(user);

            var result = await _dbContext.SaveChangesAsync();
            return result;


        }
        catch (Exception ex)
        {
            return 0;
        }
    }
}

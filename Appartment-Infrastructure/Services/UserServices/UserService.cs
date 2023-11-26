using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;


namespace Appartment_Infrastructure.Services.UserServices;
public class UserService : IUserService
{
    
    public ValueTask<int> CreateAsync(UserDto model)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> UpdateAsync(int Id, UserDto model)
    {
        throw new NotImplementedException();
    }
}

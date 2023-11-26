using Appartment_Domain.Data;
using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Application.Repositories.UserApartmentRepositories;
public class UserApartmentRepository : IUserApartmentRepository
{
    private readonly ApartmentDBContext _dbContext;

    public UserApartmentRepository(ApartmentDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ValueTask<int> CreateAsync(UserApartmentDto model)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> DeleteAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<UserApartment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserApartment> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> UpdateAsync(int Id, UserApartmentDto model)
    {
        throw new NotImplementedException();
    }
}

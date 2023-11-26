using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Application.Repositories.UserRepositories
{
    public interface IUserRepository : IBaseRepository<User,UserDto>
    {
    }
}

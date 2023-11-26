using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Infrastructure.Services.UserServices;
public interface IUserService : IBaseService<User,UserDto>
{
}

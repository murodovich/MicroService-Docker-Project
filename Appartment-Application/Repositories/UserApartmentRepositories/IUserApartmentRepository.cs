using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Application.Repositories.UserApartmentRepositories;
public interface IUserApartmentRepository : IBaseRepository<UserApartment,UserApartmentDto>
{
}

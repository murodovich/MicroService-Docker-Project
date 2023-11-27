using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;

namespace Car_Application.Repositories.OwnerCarRepositories;
public interface IOwnerCarRepository : IBaseRepository<OwnerCar,OwnerCarDto>
{
}

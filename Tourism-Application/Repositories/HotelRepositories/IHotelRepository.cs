using Tourism_Application.Dtos;
using Tourism_Domain.Entities.Models;

namespace Tourism_Application.Repositories.HotelRepositories;
public interface IHotelRepository : IBaseRepository<Hotel,HotelDto>
{
}

using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;

namespace Car_Application.Repositories.CarRepositories;
public interface ICarRepository : IBaseRepository<Car,CarDto>
{
}

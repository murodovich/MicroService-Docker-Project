using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;

namespace Car_Application.Repositories.ManufacturerRepositories;
public interface IManufacturerRepository : IBaseRepository<Manufacturer,ManufacturerDto>
{
}

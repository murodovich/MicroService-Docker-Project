using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Application.Repositories.ApartmentRepositories;
public interface IApartmentRepository : IBaseRepository<Apartment,ApartmentDto>
{
}

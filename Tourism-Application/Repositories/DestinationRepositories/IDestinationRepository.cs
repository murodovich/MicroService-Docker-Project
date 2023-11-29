using Tourism_Application.Dtos;
using Tourism_Domain.Entities.Models;

namespace Tourism_Application.Repositories.DestinationRepositories
{
    public interface IDestinationRepository : IBaseRepository<Destination,DestinationDto>
    {
    }
}

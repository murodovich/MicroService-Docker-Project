using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Application.Repositories.ReservationRepositories;
public interface IReservationRepository : IBaseRepository<Reservation,ReservationDto>
{
}

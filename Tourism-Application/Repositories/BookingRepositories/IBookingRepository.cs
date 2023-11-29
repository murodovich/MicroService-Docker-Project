using Tourism_Application.Dtos;
using Tourism_Domain.Entities.Models;

namespace Tourism_Application.Repositories.BookingRepositories
{
    public interface IBookingRepository : IBaseRepository<Booking,BookingDto>
    {
    }
}

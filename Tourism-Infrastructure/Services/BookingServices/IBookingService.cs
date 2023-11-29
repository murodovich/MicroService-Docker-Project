using Tourism_Application.Dtos;
using Tourism_Domain.Entities.Models;

namespace Tourism_Infrastructure.Services.BookingServices
{
    public interface IBookingService : IBaseservice<Booking,BookingDto>
    {
    }
}

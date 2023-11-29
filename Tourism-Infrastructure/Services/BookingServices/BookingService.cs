using Tourism_Application.Dtos;
using Tourism_Application.Repositories.BookingRepositories;
using Tourism_Domain.Entities.Models;

namespace Tourism_Infrastructure.Services.BookingServices
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _repository;

        public BookingService(IBookingRepository repository)
        {
            _repository = repository;
        }

        public ValueTask<bool> Create(BookingDto dto)
        {
            Booking booking = new Booking();
            booking.BookingDate = dto.BookingDate;
            booking.BookingPrice = dto.BookingPrice;
            booking.TourPackageId = dto.TourPackageId;
            booking.HotelId = dto.HotelId;

            var result = _repository.CreateAsync(booking);
            return result;
        }

        public ValueTask<bool> Delete(int id)
        {
            var result = _repository.DeleteAsync(id);
            return result;
        }

        public ValueTask<List<Booking>> GetAll()
        {
            var result = _repository.GetAllAsync();
            return result;
        }

        public ValueTask<Booking> GetById(int id)
        {
            var result = _repository.GetByIdAsync(id);
            return result;
        }

        public ValueTask<bool> Update(int id, BookingDto dto)
        {
            Booking booking = new Booking();
            booking.BookingDate = dto.BookingDate;
            booking.BookingPrice = dto.BookingPrice;
            booking.TourPackageId = dto.TourPackageId;
            booking.HotelId = dto.HotelId;

            var result = _repository.UpdateAsync(id, booking);
            return result;
        }
    }
}

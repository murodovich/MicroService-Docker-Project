using Microsoft.EntityFrameworkCore;
using Tourism_Application.Data;
using Tourism_Domain.Entities.Models;

namespace Tourism_Application.Repositories.BookingRepositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly TourismDBContext _dbContext;

        public BookingRepository(TourismDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask<bool> CreateAsync(Booking model)
        {
            await _dbContext.bookings.AddAsync(model);
            var result = await _dbContext.SaveChangesAsync();
            return result>0;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var result = await _dbContext.bookings.FirstOrDefaultAsync(x => x.BookingId == id);
            if(result == null)
            {
                return false;
            }
            _dbContext.bookings.Remove(result);
            var res = await _dbContext.SaveChangesAsync();
            return res > 0;
        }

        public async ValueTask<List<Booking>> GetAllAsync()
        {
            var result = await _dbContext.bookings.ToListAsync();
            return result;
        }

        public async ValueTask<Booking> GetByIdAsync(int id)
        {
            var result = await _dbContext.bookings.FirstOrDefaultAsync(x => x.BookingId == id);
            return result;
        }

        public async ValueTask<bool> UpdateAsync(int id, Booking model)
        {
            var result = await _dbContext.bookings.FirstOrDefaultAsync(x => x.BookingId == id);
            _dbContext.bookings.Update(result);
            var res = await _dbContext.SaveChangesAsync();
            return res > 0;
        }
    }
}

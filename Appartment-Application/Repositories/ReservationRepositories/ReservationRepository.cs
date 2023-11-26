using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;

namespace Appartment_Application.Repositories.ReservationRepositories
{
    public class ReservationRepository : IReservationRepository
    {
        public ValueTask<int> CreateAsync(ReservationDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Reservation>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Reservation> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(int Id, ReservationDto model)
        {
            throw new NotImplementedException();
        }
    }
}

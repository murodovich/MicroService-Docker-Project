using Microsoft.EntityFrameworkCore;
using Tourism_Application.Data;
using Tourism_Domain.Entities.Models;

namespace Tourism_Application.Repositories.DestinationRepositories
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly TourismDBContext _dbContext;

        public DestinationRepository(TourismDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask<bool> CreateAsync(Destination model)
        {
            await _dbContext.AddAsync(model);
            var result = await _dbContext.SaveChangesAsync();
            return result > 0;
        }

        public async ValueTask<bool> DeleteAsync(int id)
        {
            var result = await _dbContext.destinations.FirstOrDefaultAsync(x => x.DestinationId == id);
            _dbContext.destinations.Remove(result);
            var res = await _dbContext.SaveChangesAsync();
            return res > 0;
        }

        public async ValueTask<List<Destination>> GetAllAsync()
        {
            var result = await _dbContext.destinations.ToListAsync();
            return result;
        }

        public async ValueTask<Destination> GetByIdAsync(int id)
        {
            var result = await _dbContext.destinations.FirstOrDefaultAsync(x=>x.DestinationId == id);
            return result;
        }

        public async ValueTask<bool> UpdateAsync(int id, Destination model)
        {
            var result = await _dbContext.destinations.FirstOrDefaultAsync(x => x.DestinationId == id);
            _dbContext.destinations.Update(result);
            var res = await _dbContext.SaveChangesAsync();
            return res > 0;
        }
    }
}

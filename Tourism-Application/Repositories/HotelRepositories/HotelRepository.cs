using Microsoft.EntityFrameworkCore;
using Tourism_Application.Data;
using Tourism_Domain.Entities.Models;

namespace Tourism_Application.Repositories.HotelRepositories;
public class HotelRepository : IHotelRepository
{
    private readonly TourismDBContext _dbContext;

    public HotelRepository(TourismDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<bool> CreateAsync(Hotel model)
    {
        await _dbContext.AddAsync(model);
        var result = await _dbContext.SaveChangesAsync();
        return result > 0;
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var result = await _dbContext.hotels.FirstOrDefaultAsync(x => x.HotelId == id);
        if(result == null)
        {
            return false;
        }
        _dbContext.hotels.Remove(result);
        var res = await _dbContext.SaveChangesAsync();
        return res > 0;      
    }

    public async ValueTask<List<Hotel>> GetAllAsync()
    {
        var result =await _dbContext.hotels.ToListAsync();
        return result;
    }

    public async ValueTask<Hotel> GetByIdAsync(int id)
    {
        var result = await _dbContext.hotels.FirstOrDefaultAsync(x => x.HotelId == id);
        return result;
    }

    public async ValueTask<bool> UpdateAsync(int id,Hotel model)
    {
        var res = await _dbContext.hotels.FirstOrDefaultAsync(x =>x.HotelId == id);
        _dbContext.hotels.Update(res);
        var result = await _dbContext.SaveChangesAsync();
        return result > 0;
    }
}

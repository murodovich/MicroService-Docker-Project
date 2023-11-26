using Appartment_Domain.Data;
using Appartment_Domain.Dtos;
using Appartment_Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Appartment_Application.Repositories.ApartmentRepositories;
public class ApartmentRepository : IApartmentRepository
{
    private readonly ApartmentDBContext _dbContext;

    public ApartmentRepository(ApartmentDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(ApartmentDto model)
    {
        Apartment apartment = new Apartment();
        apartment.ApartmentName = model.ApartmentName;

        await _dbContext.Apartments.AddAsync(apartment);

        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result = await _dbContext.Apartments.FirstOrDefaultAsync(x => x.ApartmentId == Id); ;

        _dbContext.Apartments.Remove(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<Apartment>> GetAllAsync()
    {
        var list = await _dbContext.Apartments.ToListAsync();
        return list;
    }

    public async ValueTask<Apartment> GetByIdAsync(int Id)
    {
        var result = await _dbContext.Apartments.FirstOrDefaultAsync(x => x.ApartmentId == Id); ;
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, ApartmentDto model)
    {
        var result = await _dbContext.Apartments.FirstOrDefaultAsync(x => x.ApartmentId == Id); ;

        result.ApartmentName = model.ApartmentName;

        _dbContext.Apartments.Update(result);

        var res = await _dbContext.SaveChangesAsync();
        return res;
    }
}

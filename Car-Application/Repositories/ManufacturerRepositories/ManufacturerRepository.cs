using Car_Application.Data;
using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Application.Repositories.ManufacturerRepositories;
public class ManufacturerRepository : IManufacturerRepository
{
    private readonly CarDBContext _dbContext;

    public ManufacturerRepository(CarDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(ManufacturerDto model)
    {
        Manufacturer manufacturer = new Manufacturer();
        manufacturer.Name = model.ManufacturerName;

        await _dbContext.manufacturer.AddAsync(manufacturer);
        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result = await _dbContext.manufacturer.FirstOrDefaultAsync(x => x.ManufacturerId == Id);
        _dbContext.manufacturer.Remove(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<Manufacturer>> GetAllAsync()
    {
        var result = await _dbContext.manufacturer.ToListAsync();
        return result;
    }

    public async ValueTask<Manufacturer> GetByIdAsync(int Id)
    {
        var result = await _dbContext.manufacturer.FirstOrDefaultAsync(x => x.ManufacturerId == Id);
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, ManufacturerDto model)
    {
        var result = await _dbContext.manufacturer.FirstOrDefaultAsync(x => x.ManufacturerId == Id);
        result.Name = model.ManufacturerName;
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }
}


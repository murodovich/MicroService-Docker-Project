using Car_Application.Data;
using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Application.Repositories.OwnerCarRepositories;
public class OwnerCarRepository : IOwnerCarRepository
{
    private readonly CarDBContext _dbContext;

    public OwnerCarRepository(CarDBContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask<int> CreateAsync(OwnerCarDto model)
    {
        OwnerCar ownerCar = new OwnerCar();
        ownerCar.CarId = model.CarId;
        ownerCar.OwnerId = model.OwnerId;

        await _dbContext.ownerCars.AddAsync(ownerCar);
        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result = await _dbContext.ownerCars.FirstOrDefaultAsync(x => x.OwnerCarId == Id);

        _dbContext.ownerCars.Remove(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<OwnerCar>> GetAllAsync()
    {
        var result = await _dbContext.ownerCars.ToListAsync();
        return result;
    }

    public async ValueTask<OwnerCar> GetByIdAsync(int Id)
    {
        var result = await _dbContext.ownerCars.FirstOrDefaultAsync(x => x.OwnerCarId == Id);
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, OwnerCarDto model)
    {
        var result = await _dbContext.ownerCars.FirstOrDefaultAsync(x => x.OwnerCarId == Id);
        result.CarId = model.CarId;
        result.OwnerId = model.OwnerId;

        _dbContext.ownerCars.Update(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }
}

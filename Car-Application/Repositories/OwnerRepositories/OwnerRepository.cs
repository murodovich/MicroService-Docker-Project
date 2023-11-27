using Car_Application.Data;
using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Application.Repositories.OwnerRepositories;
public class OwnerRepository : IOwnerRepository
{
    private readonly CarDBContext _dbContext;

    public OwnerRepository(CarDBContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async ValueTask<int> CreateAsync(OwnerDto model)
    {
        Owner owner = new Owner();
        owner.FirstName = model.FirstName;
        owner.LastName = model.LastName;

        await _dbContext.owner.AddAsync(owner);
        var result = await _dbContext.SaveChangesAsync();
        return result;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        var result = await _dbContext.owner.FirstOrDefaultAsync(x => x.OwnerId == Id);

        _dbContext.owner.Remove(result);

        var res = await _dbContext.SaveChangesAsync();
        return res;
    }

    public async ValueTask<List<Owner>> GetAllAsync()
    {
        var result = await _dbContext.owner.ToListAsync();
        return result;
    }

    public async ValueTask<Owner> GetByIdAsync(int Id)
    {
        var result = await _dbContext.owner.FirstOrDefaultAsync(x => x.OwnerId == Id);
        return result;
    }

    public async ValueTask<int> UpdateAsync(int Id, OwnerDto model)
    {
        var result = await _dbContext.owner.FirstOrDefaultAsync(x => x.OwnerId == Id);
        result.FirstName = model.FirstName;
        result.LastName = model.LastName;

        _dbContext.owner.Update(result);
        var res = await _dbContext.SaveChangesAsync();
        return res;
    }
}

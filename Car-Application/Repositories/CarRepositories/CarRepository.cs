using Car_Application.Data;
using Car_Domain.Dtos;
using Car_Domain.Entiries.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Application.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDBContext _dbContext;

        public CarRepository(CarDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask<int> CreateAsync(CarDto model)
        {
            Car car = new Car();
            car.Year = model.Year;
            car.Model = model.Model;
            car.Price =  model.Price;
            car.ManufacturerId = model.ManufacturerId;

            await _dbContext.cars.AddAsync(car);
            var result = await _dbContext.SaveChangesAsync();
            return result;            
        }

        public async ValueTask<int> DeleteAsync(int Id)
        {
            var result = await _dbContext.cars.FirstOrDefaultAsync(x => x.CarId == Id);
            _dbContext.cars.Remove(result);
            var res = await _dbContext.SaveChangesAsync();
            return res;
        }

        public async ValueTask<List<Car>> GetAllAsync()
        {
                var result = await _dbContext.cars.ToListAsync();
            return result;
        }

        public async ValueTask<Car> GetByIdAsync(int Id)
        {
            var result = await _dbContext.cars.FirstOrDefaultAsync(x => x.CarId == Id);
            return result;
        }

        public async ValueTask<int> UpdateAsync(int Id, CarDto model)
        {
            var result = await _dbContext.cars.FirstOrDefaultAsync(x => x.CarId == Id);

            result.Year = model.Year;
            result.Model = model.Model;
            result.Price = model.Price;
            result.ManufacturerId = model.ManufacturerId;
           
            _dbContext.cars.Update(result);

            var res = await _dbContext.SaveChangesAsync();
            return res;
        }
    }
}

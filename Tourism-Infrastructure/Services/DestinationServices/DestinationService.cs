using Tourism_Application.Dtos;
using Tourism_Application.Repositories.DestinationRepositories;
using Tourism_Domain.Entities.Models;

namespace Tourism_Infrastructure.Services.DestinationServices
{
    public class DestinationService : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepository;

        public DestinationService(IDestinationRepository destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public ValueTask<bool> Create(DestinationDto dto)
        {
            Destination destination = new Destination();
            destination.Name = dto.Name;
            destination.Description = dto.Description;
            destination.City = dto.City;
            destination.Country = dto.Country;

            var result = _destinationRepository.CreateAsync(destination);
            return result;
        }

        public ValueTask<bool> Delete(int id)
        {
            var result = _destinationRepository.DeleteAsync(id);
            return result;
        }

        public ValueTask<List<Destination>> GetAll()
        {
            var result = _destinationRepository.GetAllAsync();
            return result;
        }

        public ValueTask<Destination> GetById(int id)
        {
            var result = _destinationRepository.GetByIdAsync(id);
            return result;
        }

        public ValueTask<bool> Update(int id, DestinationDto dto)
        {
            Destination destination = new Destination();
            destination.Name = dto.Name;
            destination.Description = dto.Description;
            destination.City = dto.City;
            destination.Country = dto.Country;
            
            var result = _destinationRepository.UpdateAsync(id, destination);
            return result;
        }
    }
}

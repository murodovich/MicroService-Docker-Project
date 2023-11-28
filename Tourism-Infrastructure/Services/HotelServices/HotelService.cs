using Tourism_Application.Dtos;
using Tourism_Application.Repositories.HotelRepositories;
using Tourism_Domain.Entities.Models;

namespace Tourism_Infrastructure.Services.HotelServices;
public class HotelService : IHotelService
{
    private readonly IHotelRepository _hotelRepository;

    public HotelService(IHotelRepository hotelRepository)
    {
        _hotelRepository = hotelRepository;
    }

    public ValueTask<bool> Create(HotelDto dto)
    {
        Hotel hotel = new Hotel();
        hotel.PricePerNight = dto.PricePerNight;
        hotel.StarRating = dto.StarRating;
        hotel.Name = dto.Name;
        hotel.DestinationId = dto.DestinationId;

        var result = _hotelRepository.CreateAsync(hotel);
        return result;      
    }

    public ValueTask<bool> Delete(int id)
    {
        var result = _hotelRepository.DeleteAsync(id);
        return result;
    }

    public async ValueTask<List<Hotel>> GetAll()
    {
        var result =await  _hotelRepository.GetAllAsync();
        return result;
    }

    public ValueTask<Hotel> GetById(int id)
    {
        var result = _hotelRepository.GetByIdAsync(id);
        return result;
    }

    public ValueTask<bool> Update(int id, HotelDto dto)
    {
        Hotel hotel = new Hotel();
        hotel.PricePerNight = dto.PricePerNight;
        hotel.StarRating=dto.StarRating;
        hotel.Name = dto.Name;
        hotel.DestinationId=dto.DestinationId;
        var result = _hotelRepository.UpdateAsync(id,hotel);
        return result;
    }
}

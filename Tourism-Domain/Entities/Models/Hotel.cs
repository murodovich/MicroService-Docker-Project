namespace Tourism_Domain.Entities.Models;
public class Hotel
{
    public int HotelId { get; set; }
    public string Name { get; set; }
    public int DestinationId { get; set; }
    public int StarRating { get; set; }
    public decimal PricePerNight { get; set; }
}

namespace Tourism_Domain.Entities.Models;
public class Booking
{
    public int BookingId { get; set; }
    public int TourPackageId { get; set; }
    public int HotelId { get; set; }
    public int RequiredRoomCount { get; set; }
    public decimal BookingPrice { get; set; }
    public DateTime BookingDate { get; set; }
}

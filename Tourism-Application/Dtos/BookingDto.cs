namespace Tourism_Application.Dtos;
public class BookingDto
{
    public int TourPackageId { get; set; }
    public int HotelId { get; set; }
    public int RequiredRoomCount { get; set; }
    public decimal BookingPrice { get; set; }
    public DateTime BookingDate { get; set; }
}

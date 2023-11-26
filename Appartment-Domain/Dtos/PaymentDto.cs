namespace Appartment_Domain.Dtos;
public class PaymentDto
{
    public int ReservationId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentStatus { get; set; }
}

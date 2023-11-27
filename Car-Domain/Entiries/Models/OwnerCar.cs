namespace Car_Domain.Entiries.Models;
public class OwnerCar
{
    public int OwnerCarId { get; set; }
    public int OwnerId { get; set; }
    public Owner Owner { get; set; }

    public int CarId { get; set; }
    public Car Car { get; set; }
}

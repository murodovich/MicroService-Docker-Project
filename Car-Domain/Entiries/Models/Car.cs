namespace Car_Domain.Entiries.Models;
public class Car
{
    public int CarId { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    public int ManufacturerId { get; set; }
    public Manufacturer Manufacturer { get; set; }

    public List<OwnerCar> OwnedBy { get; set; }
}

namespace Car_Domain.Entiries.Models;
public class Manufacturer
{
    public int ManufacturerId { get; set; }
    public string Name { get; set; }

    public List<Car> Cars { get; set; }
}

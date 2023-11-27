namespace Car_Domain.Entiries.Models;
public class Owner
{
    public int OwnerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<OwnerCar> OwnerCars { get; set; }
}

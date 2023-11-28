namespace Tourism_Domain.Entities.Models;
public class TourPackage
{
    public int TourPackageId { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }
}

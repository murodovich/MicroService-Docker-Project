namespace Appartment_Domain.Entities.Models
{
    public class UserApartment
    {
        public int UserApartmentId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}

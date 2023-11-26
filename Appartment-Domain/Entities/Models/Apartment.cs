using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appartment_Domain.Entities.Models
{
    public class Apartment
    {
        [ForeignKey(nameof(ApartmentId))]
        public int ApartmentId { get; set; }
        public string ApartmentName { get; set; }


        public List<UserApartment> UserApartments { get; set; }

    }
}

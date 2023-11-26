using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appartment_Domain.Entities.Models
{
    public class Reservation
    {
        [ForeignKey(nameof(ReservationId))]
        public int ReservationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public List<UserApartment> UserApartments { get; set; }
    }
}

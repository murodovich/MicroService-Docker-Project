using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appartment_Domain.Entities.Models
{
    public class User
    {
        [ForeignKey(nameof(UserId))]
        public  int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public List<UserApartment> UserApartments { get; set; }
    }
}

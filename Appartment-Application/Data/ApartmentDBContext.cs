using Appartment_Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Appartment_Domain.Data
{
    public class ApartmentDBContext : DbContext
    {
        public ApartmentDBContext(DbContextOptions<ApartmentDBContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<Reservation> reservations { get; set; }


        

    }
}

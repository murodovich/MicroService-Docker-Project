using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using Tourism_Domain.Entities.Models;

namespace Tourism_Application.Data;
public class TourismDBContext : DbContext
{
    public TourismDBContext(DbContextOptions<TourismDBContext> options) : base(options)
    {
        
    }

    public DbSet<Hotel> hotels { get; set; }
    public DbSet<Booking> bookings { get; set; }
    public DbSet<TourPackage> package { get; set; }
    public DbSet<Destination> destinations { get; set; }


}

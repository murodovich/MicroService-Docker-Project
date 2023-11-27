using Car_Domain.Entiries.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Application.Data;
public class CarDBContext : DbContext
{
    public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
    {

    }
    public DbSet<Car> cars { get; set; }
    public DbSet<Owner> owner { get; set; }
    public DbSet<Manufacturer> manufacturer { get; set; }
    public DbSet<OwnerCar> ownerCars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Car model uchun Manufacturer bo'yicha indeks qo'shish
        modelBuilder.Entity<Car>()
            .HasIndex(c => c.ManufacturerId)
            .IsUnique(false);

        // Owner va Car modellari uchun Many-to-Many bog'lanishni o'zgartirish
        modelBuilder.Entity<OwnerCar>()
            .HasKey(oc => new { oc.OwnerId, oc.CarId });

        modelBuilder.Entity<OwnerCar>()
            .HasOne(oc => oc.Owner)
            .WithMany(o => o.OwnerCars)
            .HasForeignKey(oc => oc.OwnerId);

        modelBuilder.Entity<OwnerCar>()
            .HasOne(oc => oc.Car)
            .WithMany(c => c.OwnedBy)
            .HasForeignKey(oc => oc.CarId);

        // Boshqa konfiguratsiyalar...

        base.OnModelCreating(modelBuilder);
    }

}

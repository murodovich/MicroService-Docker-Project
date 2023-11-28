﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tourism_Application.Data;

#nullable disable

namespace Tourism_Application.Migrations
{
    [DbContext(typeof(TourismDBContext))]
    partial class TourismDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tourism_Domain.Entities.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BookingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("RequiredRoomCount")
                        .HasColumnType("int");

                    b.Property<int>("TourPackageId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("Tourism_Domain.Entities.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationId");

                    b.ToTable("destinations");
                });

            modelBuilder.Entity("Tourism_Domain.Entities.Models.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"));

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StarRating")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.ToTable("hotels");
                });

            modelBuilder.Entity("Tourism_Domain.Entities.Models.TourPackage", b =>
                {
                    b.Property<int>("TourPackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourPackageId"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TourPackageId");

                    b.ToTable("package");
                });
#pragma warning restore 612, 618
        }
    }
}

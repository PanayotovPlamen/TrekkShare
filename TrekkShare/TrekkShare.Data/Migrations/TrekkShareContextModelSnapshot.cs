﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrekkShare.Data;

namespace TrekkShare.Data.Migrations
{
    [DbContext(typeof(TrekkShareContext))]
    partial class TrekkShareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrekkShare.Models.Cave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EndingTime");

                    b.Property<int>("MountainId");

                    b.Property<string>("Name");

                    b.Property<int>("StartingTime");

                    b.Property<decimal>("TicketPrice");

                    b.Property<int>("TimeIntervalWithGuide");

                    b.HasKey("Id");

                    b.HasIndex("MountainId");

                    b.ToTable("Cave");
                });

            modelBuilder.Entity("TrekkShare.Models.Cottage", b =>
                {
                    b.Property<int>("CottageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity");

                    b.Property<int>("MountainId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CottageId");

                    b.HasIndex("MountainId");

                    b.ToTable("Cottage");
                });

            modelBuilder.Entity("TrekkShare.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("TrekkShare.Models.Mountain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Altitude");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Mountain");
                });

            modelBuilder.Entity("TrekkShare.Models.Municipality", b =>
                {
                    b.Property<int>("MunicipalityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("MunicipalityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Municipality");
                });

            modelBuilder.Entity("TrekkShare.Models.Peak", b =>
                {
                    b.Property<int>("PeakId");

                    b.Property<int>("CountryId");

                    b.Property<int>("DifficultyLevel");

                    b.Property<int>("MountainId");

                    b.Property<int>("PeakElevation");

                    b.Property<string>("PeakName")
                        .IsRequired();

                    b.HasKey("PeakId");

                    b.HasIndex("CountryId");

                    b.ToTable("Peak");
                });

            modelBuilder.Entity("TrekkShare.Models.River", b =>
                {
                    b.Property<int>("RiverId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<double>("Depth");

                    b.Property<double>("Discharge");

                    b.Property<int>("Elevation");

                    b.Property<int>("FlowStrength");

                    b.Property<int>("Length");

                    b.Property<int>("MountainId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Width");

                    b.HasKey("RiverId");

                    b.HasIndex("MountainId");

                    b.ToTable("River");
                });

            modelBuilder.Entity("TrekkShare.Models.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Denivelation");

                    b.Property<int>("DifficultyLevel");

                    b.Property<double>("EndLatitude");

                    b.Property<double>("EndLongitude");

                    b.Property<double>("Length");

                    b.Property<int>("MountainId");

                    b.Property<int>("RecommendedEquipmentLevel");

                    b.Property<double>("StartLatitude");

                    b.Property<double>("StartLongitude");

                    b.Property<int>("TerrainType");

                    b.HasKey("RouteId");

                    b.HasIndex("MountainId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("TrekkShare.Models.Tourist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Experience");

                    b.Property<int>("TripsCount");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Tourist");
                });

            modelBuilder.Entity("TrekkShare.Models.TouristTrip", b =>
                {
                    b.Property<int>("TouristId");

                    b.Property<int>("TripId");

                    b.Property<DateTime>("DateTime");

                    b.HasKey("TouristId", "TripId");

                    b.HasIndex("TripId");

                    b.ToTable("TouristTrip");
                });

            modelBuilder.Entity("TrekkShare.Models.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MunicipalityId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("TownId");

                    b.HasIndex("MunicipalityId");

                    b.ToTable("Town");
                });

            modelBuilder.Entity("TrekkShare.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CottageId");

                    b.Property<TimeSpan>("Length");

                    b.Property<int>("MaxTouristsCount");

                    b.Property<int>("NightsCount");

                    b.Property<int>("RouteId");

                    b.HasKey("TripId");

                    b.HasIndex("CottageId");

                    b.HasIndex("RouteId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TrekkShare.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(60)")
                        .HasMaxLength(60)
                        .IsUnicode(true);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone")
                        .HasMaxLength(30);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)")
                        .HasMaxLength(30)
                        .IsUnicode(true);

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("TrekkShare.Models.Cave", b =>
                {
                    b.HasOne("TrekkShare.Models.Mountain", "Mountain")
                        .WithMany("Caves")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.Cottage", b =>
                {
                    b.HasOne("TrekkShare.Models.Mountain")
                        .WithMany("Cottages")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.Municipality", b =>
                {
                    b.HasOne("TrekkShare.Models.Country", "Country")
                        .WithMany("Municipalities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.Peak", b =>
                {
                    b.HasOne("TrekkShare.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrekkShare.Models.Mountain", "Mountain")
                        .WithMany("Peaks")
                        .HasForeignKey("PeakId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TrekkShare.Models.River", b =>
                {
                    b.HasOne("TrekkShare.Models.Mountain")
                        .WithMany("Rivers")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.Route", b =>
                {
                    b.HasOne("TrekkShare.Models.Mountain", "Mountain")
                        .WithMany("Routes")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.Tourist", b =>
                {
                    b.HasOne("TrekkShare.Models.User", "User")
                        .WithOne("Tourist")
                        .HasForeignKey("TrekkShare.Models.Tourist", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.TouristTrip", b =>
                {
                    b.HasOne("TrekkShare.Models.Tourist", "Tourist")
                        .WithMany("TouristTrips")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrekkShare.Models.Trip", "Trip")
                        .WithMany("TouristTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.Town", b =>
                {
                    b.HasOne("TrekkShare.Models.Municipality", "Municipality")
                        .WithMany("Towns")
                        .HasForeignKey("MunicipalityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrekkShare.Models.Trip", b =>
                {
                    b.HasOne("TrekkShare.Models.Cottage", "Cottage")
                        .WithMany()
                        .HasForeignKey("CottageId");

                    b.HasOne("TrekkShare.Models.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

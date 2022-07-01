﻿using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data;

public class HotelListingDbContext : DbContext
{
    public HotelListingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "Canada",
                ShortName = "CA"
            },
            new Country
            {
                Id = 2,
                Name = "Jamaica",
                ShortName = "JM"
            },
            new Country
            {
                Id = 3,
                Name = "Bahamas",
                ShortName = "BS"
            }
        );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "Hampton Hill",
                Address = "Québec City",
                CountryId = 1,
                Rating = 4.5
            },
            new Hotel
            {
                Id = 2,
                Name = "Sandals REsort and Spa",
                Address = "Negril",
                CountryId = 2,
                Rating = 4.3
            },
            new Hotel
            {
                Id = 3,
                Name = "Grand Palldium",
                Address = "Nassua",
                CountryId = 3,
                Rating = 4
            }
        );
    }
}
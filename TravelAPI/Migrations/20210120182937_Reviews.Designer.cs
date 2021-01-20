﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    [Migration("20210120182937_Reviews")]
    partial class Reviews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attraction")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Attraction = "Boeing",
                            Name = "Renton",
                            Rating = 9,
                            Review = "has nice hot tubs"
                        },
                        new
                        {
                            CityId = 2,
                            Attraction = "Powells",
                            Name = "Portland",
                            Rating = 8,
                            Review = "This city is pretty cool, rains a lot though"
                        },
                        new
                        {
                            CityId = 3,
                            Attraction = "Magic Gardens",
                            Name = "Philadelphia",
                            Rating = 8,
                            Review = "I hear there is lots of brotherly love here"
                        },
                        new
                        {
                            CityId = 4,
                            Attraction = "North Eastern University",
                            Name = "Boston",
                            Rating = 1,
                            Review = "has nice shrubs"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

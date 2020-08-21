﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20200821164758_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Gender = "Female",
                            Name = "Matilda",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Gender = "Female",
                            Name = "Rexie",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Gender = "Female",
                            Name = "Matilda",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Gender = "Male",
                            Name = "Pip",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 5,
                            Gender = "Male",
                            Name = "Bartholomew",
                            Type = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
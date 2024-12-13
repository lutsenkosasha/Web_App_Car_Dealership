﻿// <auto-generated />
using Car_Dealership.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Car_Dealership.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241213201303_InitialCreateV1")]
    partial class InitialCreateV1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Car_Dealership.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessLevel = 2,
                            HorsePower = 340,
                            Manufacturer = "Audi",
                            Model = "A7",
                            Price = 6000000,
                            ProductionYear = 2022
                        },
                        new
                        {
                            Id = 2,
                            AccessLevel = 1,
                            HorsePower = 600,
                            Manufacturer = "Audi",
                            Model = "RS7",
                            Price = 18000000,
                            ProductionYear = 2023
                        },
                        new
                        {
                            Id = 3,
                            AccessLevel = 1,
                            HorsePower = 620,
                            Manufacturer = "BMW",
                            Model = "M850i",
                            Price = 17000000,
                            ProductionYear = 2021
                        },
                        new
                        {
                            Id = 4,
                            AccessLevel = 2,
                            HorsePower = 320,
                            Manufacturer = "BMW",
                            Model = "M340i",
                            Price = 4500000,
                            ProductionYear = 2023
                        },
                        new
                        {
                            Id = 5,
                            AccessLevel = 3,
                            HorsePower = 350,
                            Manufacturer = "Porsche",
                            Model = "Cayman 4s",
                            Price = 4000000,
                            ProductionYear = 2017
                        });
                });

            modelBuilder.Entity("Car_Dealership.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessLevel = 1,
                            Password = "admin123",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            AccessLevel = 2,
                            Password = "manager123",
                            Username = "manager"
                        },
                        new
                        {
                            Id = 3,
                            AccessLevel = 3,
                            Password = "client123",
                            Username = "client"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
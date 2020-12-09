﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trucks.Api.DataAccess.Data;

namespace Trucks.Api.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Trucks.Api.Model.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.HasKey("PhotoId");

                    b.HasIndex("TruckId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.Truck", b =>
                {
                    b.Property<int>("TruckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Damaged")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("DefaultPhotoPath")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Hidden")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PreviousPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("TruckInventoryId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("TruckId");

                    b.HasIndex("TruckInventoryId")
                        .IsUnique();

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.TruckCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "TruckId");

                    b.HasIndex("TruckId");

                    b.ToTable("TruckCategories");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.TruckInventory", b =>
                {
                    b.Property<int>("TruckInventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("TruckInventoryId");

                    b.ToTable("TruckInventories");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.Photo", b =>
                {
                    b.HasOne("Trucks.Api.Model.Models.Truck", "Truck")
                        .WithMany("Photos")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.Truck", b =>
                {
                    b.HasOne("Trucks.Api.Model.Models.TruckInventory", "TruckInventory")
                        .WithOne("Truck")
                        .HasForeignKey("Trucks.Api.Model.Models.Truck", "TruckInventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.TruckCategory", b =>
                {
                    b.HasOne("Trucks.Api.Model.Models.Category", "Category")
                        .WithMany("TruckCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trucks.Api.Model.Models.Truck", "Truck")
                        .WithMany("TruckCategories")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

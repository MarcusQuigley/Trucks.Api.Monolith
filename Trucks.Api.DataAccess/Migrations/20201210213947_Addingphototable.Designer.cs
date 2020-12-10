﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trucks.Api.DataAccess.Data;

namespace Trucks.Api.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201210213947_Addingphototable")]
    partial class Addingphototable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("TruckPhotos");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.SalesOrder", b =>
                {
                    b.Property<int>("SalesOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerDetailsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<int>("SalesOrderDetailId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalDue")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("SalesOrderId");

                    b.ToTable("SalesOrder");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.SalesOrderDetail", b =>
                {
                    b.Property<int>("SalesOrderDetailId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SalesOrderId")
                        .HasColumnType("int");

                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.HasKey("SalesOrderDetailId");

                    b.HasIndex("TruckId");

                    b.ToTable("SalesOrderDetail");
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

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.TruckCategory", b =>
                {
                    b.Property<int>("TruckId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("TruckId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("TruckCategories");
                });

            modelBuilder.Entity("Trucks.Api.Model.Models.TruckInventory", b =>
                {
                    b.Property<int>("TruckInventoryId")
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

            modelBuilder.Entity("Trucks.Api.Model.Models.SalesOrderDetail", b =>
                {
                    b.HasOne("Trucks.Api.Model.Models.SalesOrder", "SalesOrder")
                        .WithOne("SalesDetail")
                        .HasForeignKey("Trucks.Api.Model.Models.SalesOrderDetail", "SalesOrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Trucks.Api.Model.Models.Truck", "Truck")
                        .WithMany("Sales")
                        .HasForeignKey("TruckId")
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

            modelBuilder.Entity("Trucks.Api.Model.Models.TruckInventory", b =>
                {
                    b.HasOne("Trucks.Api.Model.Models.Truck", "Truck")
                        .WithOne("TruckInventory")
                        .HasForeignKey("Trucks.Api.Model.Models.TruckInventory", "TruckInventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

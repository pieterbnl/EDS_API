﻿// <auto-generated />
using System;
using EnergyDataSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnergyDataSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("BuildingGroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("BuildingGroupId");

                    b.HasIndex("ContactId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.BuildingGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("BuildingGroups");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.EnergyMeter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("EnergyMeters");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Measurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EnergyMeterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnergyMeterId");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ContactId")
                        .IsUnique();

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Phonenumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfPhonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Phonenumbers");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Building", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.Address", "Address")
                        .WithOne("Building")
                        .HasForeignKey("EnergyDataSystem.Entities.Models.Building", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnergyDataSystem.Entities.Models.BuildingGroup", "BuildingGroup")
                        .WithMany("Buildings")
                        .HasForeignKey("BuildingGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnergyDataSystem.Entities.Models.Contact", null)
                        .WithMany("Buildings")
                        .HasForeignKey("ContactId");

                    b.Navigation("Address");

                    b.Navigation("BuildingGroup");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.BuildingGroup", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.Owner", "Owner")
                        .WithMany("BuildingGroups")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Contact", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Email", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.Contact", "Contact")
                        .WithMany("Emails")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.EnergyMeter", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.Building", "Building")
                        .WithMany("EnergyMeters")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Measurement", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.EnergyMeter", "EnergyMeter")
                        .WithMany("Measurements")
                        .HasForeignKey("EnergyMeterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnergyMeter");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Owner", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnergyDataSystem.Entities.Models.Contact", "Contact")
                        .WithOne("Owner")
                        .HasForeignKey("EnergyDataSystem.Entities.Models.Owner", "ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Phonenumber", b =>
                {
                    b.HasOne("EnergyDataSystem.Entities.Models.Contact", "Contact")
                        .WithMany("Phonenumbers")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Address", b =>
                {
                    b.Navigation("Building");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Building", b =>
                {
                    b.Navigation("EnergyMeters");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.BuildingGroup", b =>
                {
                    b.Navigation("Buildings");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Contact", b =>
                {
                    b.Navigation("Buildings");

                    b.Navigation("Emails");

                    b.Navigation("Owner");

                    b.Navigation("Phonenumbers");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.EnergyMeter", b =>
                {
                    b.Navigation("Measurements");
                });

            modelBuilder.Entity("EnergyDataSystem.Entities.Models.Owner", b =>
                {
                    b.Navigation("BuildingGroups");
                });
#pragma warning restore 612, 618
        }
    }
}

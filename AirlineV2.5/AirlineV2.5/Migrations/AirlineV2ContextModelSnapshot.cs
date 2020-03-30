﻿// <auto-generated />
using System;
using AirlineV2._5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirlineV2._5.Migrations
{
    [DbContext(typeof(AirlineV2Context))]
    partial class AirlineV2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirlineV2._5.Models.Aircraft", b =>
                {
                    b.Property<int>("AcID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcCapacity")
                        .HasColumnType("int");

                    b.Property<string>("AcModel")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("AcModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("AcRegisterDate")
                        .HasColumnType("datetime");

                    b.Property<string>("AcType")
                        .IsRequired()
                        .HasColumnType("varchar(45)");

                    b.HasKey("AcID");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("AirlineV2._5.Models.Client", b =>
                {
                    b.Property<int>("ClnID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ClnBirthdate")
                        .HasColumnType("date");

                    b.Property<string>("ClnEmail")
                        .IsRequired()
                        .HasColumnType("varchar(320)");

                    b.Property<string>("ClnLastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ClnName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ClnPhone")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<DateTime>("ClnRegisterDate")
                        .HasColumnType("datetime");

                    b.HasKey("ClnID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AirlineV2._5.Models.ClnRelFlg", b =>
                {
                    b.Property<int>("ClnFlgID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClnID")
                        .HasColumnType("int");

                    b.Property<int>("FlgID")
                        .HasColumnType("int");

                    b.HasKey("ClnFlgID");

                    b.HasIndex("ClnID");

                    b.HasIndex("FlgID");

                    b.ToTable("ClnFlgRels");
                });

            modelBuilder.Entity("AirlineV2._5.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EmpBirthdate")
                        .HasColumnType("Date");

                    b.Property<string>("EmpCardID")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("EmpEmail")
                        .IsRequired()
                        .HasColumnType("varchar(320)");

                    b.Property<string>("EmpGender")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<DateTime>("EmpHireDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("EmpHomeAdrs")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("EmpLastName")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<DateTime?>("EmpModifiedDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("EmpPhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("EmpSalary")
                        .HasColumnType("int");

                    b.Property<string>("EmpType")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("EmpID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AirlineV2._5.Models.Flight", b =>
                {
                    b.Property<int>("FlgID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FlgArrival")
                        .HasColumnType("datetime");

                    b.Property<string>("FlgCategory")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<DateTime>("FlgDeparture")
                        .HasColumnType("datetime");

                    b.Property<int>("FlgFare")
                        .HasColumnType("int");

                    b.HasKey("FlgID");

                    b.HasIndex("AcID");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AirlineV2._5.Models.FlightAssignedTo", b =>
                {
                    b.Property<int>("FlgEmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.Property<int>("FlgID")
                        .HasColumnType("int");

                    b.HasKey("FlgEmpID");

                    b.HasIndex("EmpID");

                    b.HasIndex("FlgID");

                    b.ToTable("FlightAssignedEmps");
                });

            modelBuilder.Entity("AirlineV2._5.Models.ClnRelFlg", b =>
                {
                    b.HasOne("AirlineV2._5.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("ClnID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirlineV2._5.Models.Flight", "flight")
                        .WithMany()
                        .HasForeignKey("FlgID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirlineV2._5.Models.Flight", b =>
                {
                    b.HasOne("AirlineV2._5.Models.Aircraft", "aircraft")
                        .WithMany()
                        .HasForeignKey("AcID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirlineV2._5.Models.FlightAssignedTo", b =>
                {
                    b.HasOne("AirlineV2._5.Models.Employee", "employee")
                        .WithMany("FlightsAssigned")
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirlineV2._5.Models.Flight", "flight")
                        .WithMany()
                        .HasForeignKey("FlgID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

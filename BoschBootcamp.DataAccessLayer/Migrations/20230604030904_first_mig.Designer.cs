﻿// <auto-generated />
using System;
using BoschBootcamp.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoschBootcamp.DataAccessLayer.Migrations
{
    [DbContext(typeof(Concrete.BBContext))]
    [Migration("20230604030904_first_mig")]
    partial class first_mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Area", b =>
                {
                    b.Property<string>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AreaId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Injector", b =>
                {
                    b.Property<int>("InjectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InjectorID"));

                    b.Property<decimal>("InjectorPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InjectorStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("InjectorID");

                    b.ToTable("Injectors");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Models", b =>
                {
                    b.Property<string>("ModelNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelNumber");

                    b.ToTable("Modelss");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<string>("ModelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Section", b =>
                {
                    b.Property<int>("SectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectionID"));

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("ModelNumber")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Station", b =>
                {
                    b.Property<int>("StationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationID"));

                    b.HasKey("StationID");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.StationProcess", b =>
                {
                    b.Property<int>("StationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationID"));

                    b.Property<int>("InjectorID")
                        .HasColumnType("int");

                    b.Property<string>("ProcessStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProcessTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubcomponentID")
                        .HasColumnType("int");

                    b.HasKey("StationID");

                    b.ToTable("StationProcesses");
                });

            modelBuilder.Entity("BoschBootcamp.EntityLayer.Concrete.Subcomponent", b =>
                {
                    b.Property<int>("SubcomponentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubcomponentID"));

                    b.Property<int>("InjectorID")
                        .HasColumnType("int");

                    b.Property<int>("StationID")
                        .HasColumnType("int");

                    b.Property<decimal>("SubcomponentCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SubcomponentID");

                    b.ToTable("Subcomponents");
                });
#pragma warning restore 612, 618
        }
    }
}

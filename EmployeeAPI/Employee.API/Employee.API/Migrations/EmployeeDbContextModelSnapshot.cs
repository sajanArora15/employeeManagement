﻿// <auto-generated />
using System;
using Employee.API.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Employee.API.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employee.API.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Department");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<long>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

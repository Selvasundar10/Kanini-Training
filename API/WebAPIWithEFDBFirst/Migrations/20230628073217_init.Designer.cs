﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIWithEFDBFirst.Models;

#nullable disable

namespace WebAPIWithEFDBFirst.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20230628073217_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPIWithEFDBFirst.Models.Student", b =>
                {
                    b.Property<int>("StudId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pin")
                        .HasColumnType("int")
                        .HasColumnName("pin");

                    b.HasKey("StudId");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}

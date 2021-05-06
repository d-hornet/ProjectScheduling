﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scheduling.Domain;

namespace Scheduling.Migrations
{
    [DbContext(typeof(UserDBContext))]
    [Migration("20210410144938_updateDB")]
    partial class updateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scheduling.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permisson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1321313,
                            Department = "Memes",
                            Email = "admin@gmail.com",
                            Name = "User",
                            Password = "5dj3bhWCfxuHmONkBdvFrA==",
                            Permisson = "canManageUsers;isPartTime",
                            Position = "lol",
                            Salt = "91ed90df-3289-4fdf-a927-024b24bea8b7",
                            Surname = "UserS"
                        },
                        new
                        {
                            Id = 13213133,
                            Department = "Memes",
                            Email = "user@gmail.com",
                            Name = "User",
                            Password = "u9DAYiHl+liIqRMvuuciBA==",
                            Permisson = "canManageUsers;isPartTime",
                            Position = "lol",
                            Salt = "f0e30e73-fac3-4182-8641-ecba862fed",
                            Surname = "UserS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

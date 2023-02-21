﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission6_mcurzon1.Models;

namespace mission6_mcurzon1.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230221000306_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission6_mcurzon1.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Sci-Fi"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Crime/Action"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Romance/Comedy"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Sci-Fi/Fantasy"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Drama/Romance"
                        },
                        new
                        {
                            CategoryID = 11,
                            CategoryName = "Action/Thriller"
                        },
                        new
                        {
                            CategoryID = 12,
                            CategoryName = "Drama"
                        });
                });

            modelBuilder.Entity("mission6_mcurzon1.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 12,
                            Director = "Richard Linklater",
                            Edited = false,
                            Rating = "R",
                            Title = "Before Sunrise",
                            Year = (ushort)1995
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 12,
                            Director = "Richard Linklater",
                            Edited = false,
                            Rating = "R",
                            Title = "Before Sunset",
                            Year = (ushort)2004
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 7,
                            Director = "Quentin Tarantino",
                            Edited = false,
                            Rating = "R",
                            Title = "Pulp Fiction",
                            Year = (ushort)1994
                        });
                });

            modelBuilder.Entity("mission6_mcurzon1.Models.Movie", b =>
                {
                    b.HasOne("mission6_mcurzon1.Models.Category", "CategoryName")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

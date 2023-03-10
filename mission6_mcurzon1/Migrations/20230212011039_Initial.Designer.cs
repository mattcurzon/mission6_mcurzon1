// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission6_mcurzon1.Models;

namespace mission6_mcurzon1.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230212011039_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission6_mcurzon1.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<ushort>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Drama",
                            Director = "Richard Linklater",
                            Rating = "R",
                            Title = "Before Sunrise",
                            Year = (ushort)1995
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Drama",
                            Director = "Richard Linklater",
                            Rating = "R",
                            Title = "Before Sunset",
                            Year = (ushort)2004
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Crime/Drama",
                            Director = "Quentin Tarantino",
                            Rating = "R",
                            Title = "Pulp Fiction",
                            Year = (ushort)1994
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

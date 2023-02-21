using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mission6_mcurzon1.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        { // seed database with 3 movies

            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action" },
                new Category { CategoryID = 2, CategoryName = "Comedy"},
                new Category { CategoryID = 3, CategoryName = "Sci-Fi" },
                new Category { CategoryID = 4, CategoryName = "Horror" },
                new Category { CategoryID = 5, CategoryName = "Romance" },
                new Category { CategoryID = 6, CategoryName = "Thriller" },
                new Category { CategoryID = 7, CategoryName = "Crime/Action" },
                new Category { CategoryID = 8, CategoryName = "Romance/Comedy" },
                new Category { CategoryID = 9, CategoryName = "Sci-Fi/Fantasy" },
                new Category { CategoryID = 10, CategoryName = "Drama/Romance" },
                new Category { CategoryID = 11, CategoryName = "Action/Thriller" },
                new Category { CategoryID = 12, CategoryName = "Drama" }
                 );

            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    CategoryID = 12,
                    Title = "Before Sunrise",
                    Year = 1995,
                    Director = "Richard Linklater",
                    Rating = "R"
                },
                new Movie
                {
                    MovieID = 2,
                    CategoryID = 12,
                    Title = "Before Sunset",
                    Year = 2004,
                    Director = "Richard Linklater",
                    Rating = "R"
                },
                new Movie
                {
                    MovieID = 3,
                    CategoryID = 7,
                    Title = "Pulp Fiction",
                    Year = 1994,
                    Director = "Quentin Tarantino",
                    Rating = "R",
                }
            );
        }
    }
}

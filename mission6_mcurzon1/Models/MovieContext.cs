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

        protected override void OnModelCreating(ModelBuilder mb)
        { // seed database with 3 movies
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    Category = "Drama",
                    Title = "Before Sunrise",
                    Year = 1995,
                    Director = "Richard Linklater",
                    Rating = "R"
                },
                new Movie
                {
                    MovieID = 2,
                    Category = "Drama",
                    Title = "Before Sunset",
                    Year = 2004,
                    Director = "Richard Linklater",
                    Rating = "R"
                },
                new Movie
                {
                    MovieID = 3,
                    Category = "Crime/Drama",
                    Title = "Pulp Fiction",
                    Year = 1994,
                    Director = "Quentin Tarantino",
                    Rating = "R",
                }
            );
        }
    }
}

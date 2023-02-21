using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission6_mcurzon1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_mcurzon1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _movieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext movie)
        {
            _logger = logger;
            _movieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            if (ModelState.IsValid) // if input is valid add it to database
            {
                _movieContext.Add(movie);
                _movieContext.SaveChanges();
                return View("Confirmation", movie); // return confirmation page
            }
            else // else return it to the same page
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult AllMovies()
        {
            var movies = _movieContext.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]        
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            var movie = _movieContext.Movies.Single(x => x.MovieID == movieid);

            return View("AddMovie", movie);
        }
        [HttpPost]
        public IActionResult Edit (Movie movie)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            if (ModelState.IsValid)
            {   
                _movieContext.Update(movie);
                _movieContext.SaveChanges();
                return RedirectToAction("AllMovies");
            }
            else
            {
                return View("AddMovie", movie);
            }
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _movieContext.Movies.Single(x => x.MovieID == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete (Movie movie)
        {

            _movieContext.Movies.Remove(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("AllMovies");


        }
    }
}

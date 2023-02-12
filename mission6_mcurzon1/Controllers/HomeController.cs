﻿using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            _movieContext.Add(movie);
            _movieContext.SaveChanges();
            return View("Confirmation", movie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

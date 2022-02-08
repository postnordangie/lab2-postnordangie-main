using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieLab.Models;

namespace MovieLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var actors = Actor.GetAllActors();
            var movies = Movie.GetAllMovies();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult before_2000_newest()
        {
            return View();
        }

        public IActionResult drama_newest()
        {
            return View();
        }

        public IActionResult Robin_Williams_alphabetical()
        {
            return View();
        }

        public IActionResult three_actors_oldest()
        {
            return View();
        }

        public IActionResult this_movie(int id)
        {
            var movie = Movie.GetAllMovies()
            .FirstOrDefault(x => x.Id == id); //firstordefault t movie task controller;


            return View("this_movie", movie);
        }

        public IActionResult this_actor_movies(string id)
        {
            var actor = Actor.GetAllActors()
            .FirstOrDefault(x => x.Id == id);
            
            return View("this_actor_movies", actor);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

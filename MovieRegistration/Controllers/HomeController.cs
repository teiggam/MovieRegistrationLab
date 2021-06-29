using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Registration()
        {
            return View();

        }
        public IActionResult Results(Movies inputMovie)
        {
            return View(inputMovie);
        }


        MovieDbContext db = new MovieDbContext();
        public IActionResult MovieList()
        {
            List<Movies> m = db.Movies.ToList();
            return View(m);
        }

        public static void AddMovie(Movies mov, MovieDbContext db)
        {

            db.Movies.Add(mov);
            db.SaveChanges();
        }
    }

}

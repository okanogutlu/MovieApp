using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;
            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}

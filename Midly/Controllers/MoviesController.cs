using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Midly.Models;



namespace Midly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek" };
        //    //return View(movie);
        //    return Content("Hello world!");
        //}


        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}



        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}



        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }



        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith" },
                new Customer {Name = "Mary Williams" }
            };

            var viewModel = new ViewModels.RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            //ViewData["Movie"] = movie;
            return View(viewModel);
        }
    }
}
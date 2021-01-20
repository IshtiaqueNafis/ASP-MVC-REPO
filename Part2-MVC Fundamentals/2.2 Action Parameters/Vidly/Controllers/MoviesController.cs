using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Data;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET
       private MovieReposotory _movieReposotory = null;

       public MoviesController()
       {
           _movieReposotory = new MovieReposotory(); // instance is being created here 
       }
        
        
        public ActionResult Index()
        {
            var movies = _movieReposotory.GetMovies();
            return View(movies);

        }
        
        
        
        public ActionResult Random()
        {
            var movie = new Movie(){Name="Batman Begins"}; // created an object 

            var customers = new List<Customer>
            {
                new Customer {Name = "customer 1"},
                new Customer {Name = "Customer2"}
            }; // creating customer here 
            var viewModel = new RandomMovieViewModel.RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);

        }

        public ActionResult Edit(int Id)
        {
           

            return Content($"ID={Id}");
        }
        
        //index 
        // public ActionResult Index(int? pageIndex,string sortBy)
        // {
        //     //? means nullable 
        //     if (!pageIndex.HasValue)
        //     {
        //         pageIndex = 1;
        //     }
        //
        //     if (string.IsNullOrWhiteSpace(sortBy))
        //     {
        //         sortBy = "name";
        //     }
        //
        //     return Content($"pageindex={pageIndex} & sortBy = {sortBy}");
        //
        // }
        
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReLeaseDate(int year, int month)
        {
            return Content($"year={year} month={month}");
        }

        public ActionResult Genre(int? year, string rating)
        {
            if (!year.HasValue)
            {
                year = 1993;
            }
            
            

            return Content($"year={year} rating={rating}");
        }

    }
}
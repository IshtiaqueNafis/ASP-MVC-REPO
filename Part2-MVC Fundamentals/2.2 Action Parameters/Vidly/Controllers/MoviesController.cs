using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movie = new Movie(){Name="Batman Begins"}; // created an object 
            return View(movie);

        }

        public ActionResult Edit(int Id)
        {
           

            return Content($"ID={Id}");
        }
        
        //index 
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            //? means nullable 
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }

            return Content($"pageindex={pageIndex} & sortBy = {sortBy}");

        }

    }
}
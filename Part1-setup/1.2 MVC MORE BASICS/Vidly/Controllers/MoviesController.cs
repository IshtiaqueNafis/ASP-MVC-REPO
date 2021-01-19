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
            return View(movie); // a object of movie is passed to View this will be returned on soon to be create View folder. 
        }
    }
}
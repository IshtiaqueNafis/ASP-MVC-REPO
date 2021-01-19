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
            return RedirectToAction("Index", "Home",new {page=1,sortBy="name"});
            //index is action name 
            // Home is the controller 
            // new is the annonymous object here 
            
            
        }
    }
}
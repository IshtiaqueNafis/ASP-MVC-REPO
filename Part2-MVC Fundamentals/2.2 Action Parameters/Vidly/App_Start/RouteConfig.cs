using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // routes.MapRoute(
            //     "MoviesByReLeaseDate", // name is thr nsame of the route 
            //     "movies/released/{year}/{month}", // url is how the url will be be  remeber the controller can be named anything  
            //     new {controller = "movies", action = "ByReLeaseDate"}, // controller has to be defined or it wont work 
            //     new {year=@"\d{4}",month=@"\d{2}"} // this is the constraints  for data type 
            //
            // );
          // my custom router 
            // routes.MapRoute(
            //     "movieGenre", // this is the name for the router 
            //     "movies/genre/{year}/{rating}", // movie controller name, genre is action name and year and rating are both parameter 
            //     new {controller = "movies", action = "genre"} 
            //
            //
            //     
            //     // more finer way to do it 
            //     
            //
            // ); 
            routes.MapMvcAttributeRoutes();    
            
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}
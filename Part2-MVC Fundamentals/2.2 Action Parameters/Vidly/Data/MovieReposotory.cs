using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.Data
{
    public class MovieReposotory
    {
        private static List<Movie> _movies = new List<Movie>
        {
         new Movie(){Id = 1,Name="batman begins"},
         new Movie(){Id = 2,Name="Darknight Rises"}
        };

        public List<Movie> GetMovies() => _movies;

        public Movie GetMovie(int id)
        {
            Movie movieTOReturn = null;
            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                {
                    movieTOReturn = movie;
                    break;
                }
            }

            return movieTOReturn;
        }
    }
}
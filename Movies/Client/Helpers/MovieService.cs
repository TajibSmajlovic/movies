using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Helpers
{
    public class MovieService : IMovieService
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>() {
            new Movie() { Title  = "<i>Kod amidze Idriya</i>", RealeaseDate = new DateTime(2000,1,1) },
            new Movie() { Title  = "Gori vatra", RealeaseDate = new DateTime(2000,1,1) },
        };
        }
    }
}
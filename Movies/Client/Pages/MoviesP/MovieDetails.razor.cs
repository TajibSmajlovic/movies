using Microsoft.AspNetCore.Components;
using Movies.Client.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages.MoviesP
{
    public partial class MovieDetails
    {
        [Inject] public IMoviesRepository movieRepository { get; set; }
        [Parameter] public int MovieId { get; set; }
        [Parameter] public string MovieName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var movie = await movieRepository.GetMovieDetails(MovieId);
                Console.WriteLine(movie.Title);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
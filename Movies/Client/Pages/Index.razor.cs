using Microsoft.AspNetCore.Components;
using Movies.Client.Helpers;
using Movies.Client.Shared;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Movies.Client.Shared.MainLayout;

namespace Movies.Client.Pages
{
    public partial class Index
    {
        // [CascadingParameter] public AppState appState { get; set; }
        [Inject] private IMovieService movieService { get; set; }

        private List<Movie> Movies;

        protected async override Task OnInitializedAsync()
        {
            //if (moviesList.Movies != null)
            //    Console.WriteLine(moviesList.Movies.FirstOrDefault(x => x.Title == "Gori vatra")); // ref

            await FetchMoviesAsync();
        }

        private async Task FetchMoviesAsync()
        {
            await Task.Delay(2000);

            Movies = movieService.GetMovies();
        }
    }
}
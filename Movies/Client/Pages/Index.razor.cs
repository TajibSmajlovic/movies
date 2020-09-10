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
        [CascadingParameter] public AppState appState { get; set; }
        [Inject] private IMovieService movieService { get; set; }
        private MoviesList moviesList;
        private List<Movie> movies;
        private bool loading = false;

        protected async override Task OnInitializedAsync()
        {
            //if (moviesList.Movies != null)
            //    Console.WriteLine(moviesList.Movies.FirstOrDefault(x => x.Title == "Gori vatra")); // ref

            await FetchMoviesAsync();
        }

        private async Task FetchMoviesAsync()
        {
            loading = true;

            await Task.Delay(2000);

            movies = movieService.GetMovies();

            loading = false;
        }

        private void AddMovie()
        {
            movies.Add(new Movie() { Title = "New Movie", RealeaseDate = new DateTime(2003, 2, 6) });
        }
    }
}
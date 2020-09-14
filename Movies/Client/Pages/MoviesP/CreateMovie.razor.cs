using Microsoft.AspNetCore.Components;
using Movies.Client.Repository;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages.MoviesP
{
    public partial class CreateMovie
    {
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] private IMoviesRepository moviesRepository { get; set; }

        private Movie Movie = new Movie();

        private async Task CreateMovieHandler()
        {
            try

            {
                var createdMovieId = await moviesRepository.CreateMovie(Movie);
                navigationManager.NavigateTo($"movies/{createdMovieId}");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
using Microsoft.AspNetCore.Components;
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
        private Movie Movie = new Movie();

        private void CreateMovieHandler()
        {
            navigationManager.NavigateTo("movie");
        }
    }
}
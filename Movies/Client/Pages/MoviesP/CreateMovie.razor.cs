using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages.MoviesP
{
    public partial class CreateMovie
    {
        [Inject] private NavigationManager navigationManager { get; set; }

        private void CreateMovieHandler()
        {
            navigationManager.NavigateTo("movie");
        }
    }
}
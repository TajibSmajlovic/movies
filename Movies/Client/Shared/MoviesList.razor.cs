using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Movies.Client.Helpers;
using Movies.Shared.Entities;
using System.Collections.Generic;

namespace Movies.Client.Shared
{
    public partial class MoviesList
    {
        [Inject] public IJSRuntime Js { get; set; }

        [Parameter] public List<Movie> Movies { get; set; }

        private async void DeleteMovie(Movie movie)
        {
            bool shouldDelete = await Js.Confirm("Are you sure you want to delete?");

            System.Console.WriteLine(shouldDelete);

            if (shouldDelete)
            {
                Movies.Remove(movie);
                StateHasChanged();
            }
        }
    }
}
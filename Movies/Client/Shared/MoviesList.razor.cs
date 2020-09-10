using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Movies.Client.Helpers;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Shared
{
    public partial class MoviesList
    {
        public bool displayButtons = true;

        [Inject] public IJSRuntime js { get; set; }
        [Parameter] public bool Loading { get; set; }

        [Parameter] public List<Movie> Movies { get; set; }
        [Parameter] public RenderFragment NullTemplate { get; set; }
        [Parameter] public RenderFragment LoadingTemplate { get; set; }

        private async void DeleteMovie(Movie movie)
        {
            await js.Log(movie.Title);

            bool shouldDelete = await js.Confirm("Are you sure you want to delete?");

            if (shouldDelete)
                Movies.Remove(movie);
        }

        public void Test()
        {
        }

        protected override void OnInitialized()
        {
            Console.WriteLine("OnInitialized!");
        }

        protected override void OnParametersSet()
        {
            if (Movies != null)
            {
                Console.WriteLine("Movies: " + Movies.Count.ToString());
            }
            Console.WriteLine("OnParametersSet!");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine("OnAfterRender! firstRender: ", firstRender);
        }

        protected override bool ShouldRender()
        {
            return true;
        }
    }
}
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages.MoviesP
{
    public partial class MovieDetails
    {
        [Parameter] public int MovieId { get; set; }
        [Parameter] public string MovieName { get; set; }

        protected override void OnInitialized()
        {
            Console.WriteLine(MovieId);
            Console.WriteLine(MovieName);
        }
    }
}
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages.Genres
{
    public partial class EditGenre
    {
        [Parameter] public int GenreId { get; set; }

        protected override void OnInitialized()
        {
        }
    }
}
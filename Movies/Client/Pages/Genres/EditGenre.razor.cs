using Microsoft.AspNetCore.Components;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Pages.Genres
{
    public partial class EditGenre
    {
        [Parameter] public int GenreId { get; set; }
        public Genre genre;

        protected override void OnInitialized()
        {
            genre = new Genre()
            {
                Id = GenreId,
                Name = "Comedy"
            };
        }

        private void Edit()
        {
            Console.WriteLine(genre.Name);
            Console.WriteLine(GenreId);
        }
    }
}
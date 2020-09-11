using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public DateTime RealeaseDate { get; set; }
        public string Poster { get; set; }

        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Title))
                    return null;

                return Title.Length > 60 ? Title.Substring(0, 60) + "..." : Title;
            }
        }
    }
}
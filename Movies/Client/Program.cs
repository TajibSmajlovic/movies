using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Movies.Client.Helpers;
using Tewr.Blazor.FileReader;
using BlazorMovies.Client.Helpers;
using Movies.Client.Repository;

namespace Movies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<IMovieService, MovieService>();
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddTransient<IGenreRepository, GenreRepository>();
            builder.Services.AddTransient<IPersonRepository, PersonRepository>();
            builder.Services.AddTransient<IMoviesRepository, MoviesRepository>();

            builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);

            await builder.Build().RunAsync();
        }
    }
}
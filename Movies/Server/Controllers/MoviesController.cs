using Microsoft.AspNetCore.Mvc;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)

        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            _context.Add(movie);

            await _context.SaveChangesAsync();

            return Ok(movie.Id);
        }

        [HttpGet("{movieId}")]
        public ActionResult<Movie> GetMovie(int movieId)
        {
            var res = _context.Movies.Where(x => x.Id == movieId);

            return Ok(res);
        }
    }
}
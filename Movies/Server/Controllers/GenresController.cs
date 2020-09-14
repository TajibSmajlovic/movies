using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Client.Pages.Genres;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GenresController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Genre>> Post(Genre genre)
        {
            context.Add(genre);

            await context.SaveChangesAsync();

            return Ok(genre);
        }

        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await context.Genres.ToListAsync();
        }

        [HttpGet("id")]
        public async Task<ActionResult<Genre>> Get(int id)
        {
            var res = await context.Genres.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(res);
        }
    }
}
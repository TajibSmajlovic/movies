using Microsoft.AspNetCore.Mvc;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Server.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PersonsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonsController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Person>> Post(Person person)
        {
            _context.Add(person);
            await _context.SaveChangesAsync();

            return Ok(person);
        }
    }
}
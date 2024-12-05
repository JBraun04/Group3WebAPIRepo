using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Group3WebAPI.Data;
using Group3WebAPI.Models;

namespace Group3WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        private readonly Group3WebAPIContext _context;

        public HobbiesController(Group3WebAPIContext context)
        {
            _context = context;
        }

        // GET: api/Hobbies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobby() {
            return await _context.Hobby.ToListAsync();
        }

        // GET: api/Hobbies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hobby>> GetHobby(int id) {
            var hobby = await _context.Hobby.FindAsync(id);

            if (hobby == null) {
                return NotFound();
            }

            return hobby;
        }

        // PUT: api/Hobbies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHobby(int id, Hobby hobby) {
            if (id != hobby.Id) {
                return BadRequest();
            }

            _context.Entry(hobby).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!HobbyExists(id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hobbies
        [HttpPost]
        public async Task<ActionResult<Hobby>> PostHobby(Hobby hobby) {
            _context.Hobby.Add(hobby);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHobby", new { id = hobby.Id }, hobby);
        }

        // DELETE: api/Hobbies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHobby(int id) {
            var hobby = await _context.Hobby.FindAsync(id);
            if (hobby == null) {
                return NotFound();
            }

            _context.Hobby.Remove(hobby);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool HobbyExists(int id) {
            return _context.Hobby.Any(e => e.Id == id);
        }
    }
}

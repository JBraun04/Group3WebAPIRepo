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
    public class TravelDestinationsController : ControllerBase
    {
        private readonly Group3WebAPIContext _context;

        public TravelDestinationsController(Group3WebAPIContext context)
        {
            _context = context;
        }

        // GET: api/TravelDestinations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravelDestination>>> GetTravelDestinations()
        {
            return await _context.TravelDestination.ToListAsync();
        }

        // GET: api/TravelDestinations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TravelDestination>> GetTravelDestination(int id)
        {
            var travelDestination = await _context.TravelDestination.FindAsync(id);

            if (travelDestination == null)
            {
                return NotFound();
            }

            return travelDestination;
        }

        // PUT: api/TravelDestinations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravelDestination(int id, TravelDestination travelDestination)
        {
            if (id != travelDestination.Id)
            {
                return BadRequest();
            }

            _context.Entry(travelDestination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelDestinationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TravelDestinations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TravelDestination>> PostTravelDestination(TravelDestination travelDestination)
        {
            _context.TravelDestination.Add(travelDestination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTravelDestination", new { id = travelDestination.Id }, travelDestination);
        }

        // DELETE: api/TravelDestinations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTravelDestination(int id)
        {
            var travelDestination = await _context.TravelDestination.FindAsync(id);
            if (travelDestination == null)
            {
                return NotFound();
            }

            _context.TravelDestination.Remove(travelDestination);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravelDestinationExists(int id)
        {
            return _context.TravelDestination.Any(e => e.Id == id);
        }
    }
}

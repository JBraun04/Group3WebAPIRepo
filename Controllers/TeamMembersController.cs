using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Group3WebAPI.Data;
using Group3WebAPI.Models;

namespace Group3WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : Controller
    {
        private readonly Group3WebAPIContext _context;

        public TeamMembersController(Group3WebAPIContext context)
        {
            _context = context;
        }

        // GET: TeamMembers
        [HttpGet]
        public IActionResult GetTeamMembers()
        {
            return Ok(_context.TeamMember.ToList());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamMember>> GetTeamMember(int id)
        {
            if (id == 0 || id == null)
            {
                var teammember = await _context.TeamMember.Take(5).ToListAsync();

                return Ok(teammember);
            }
            else
            {
                var teammember = await _context.TeamMember.FindAsync(id);

                if (teammember == null)
                {
                    return NotFound();
                }

                return Ok(teammember);
            }
        }
        [HttpPost]
        public IActionResult PostTeamMember(TeamMember teamMember)
        {
            _context.TeamMember.Add(teamMember);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTeamMember(int id)
        {
            TeamMember teamMember = _context.TeamMember.Find(id);
            if (teamMember == null)
            {
                return NotFound();
            }
            try
            {
                _context.TeamMember.Remove(teamMember);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutTeamMember(TeamMember teamMember)
        {
            //var s = _context.TeamMember.Find(teamMember.Id);
            //if (s == null)
            //{
            //    return NotFound();
            //}
            //s.First_name = teamMember.First_name;
            //s.Last_name = teamMember.Last_name;
            //s.Year = teamMember.Year;
            //s.Age = teamMember.Age;
            //_context.TeamMember.Update(s);
            try
            {
                _context.Entry(teamMember).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }
        // POST: api/Breakfasts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        private bool TeamMemberExists(int id)
        {
            return _context.TeamMember.Any(e => e.Id == id);
        }
    }
}

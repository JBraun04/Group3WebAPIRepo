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
    public class TeamMembersController : Controller
    {
        private readonly Group3WebAPIContext _context;

        public TeamMembersController(Group3WebAPIContext context)
        {
            _context = context;
        }

        // GET: TeamMembers
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_context.TeamMember.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            TeamMember teammember = _context.TeamMember.Find(id);
            if (teammember == null)
            {
                return NotFound();
            }
            return Ok(teammember);
        }
    }
}

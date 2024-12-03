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
        public IActionResult GetHobbies() {
            return Ok(_context.Hobby.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetHobby(int id) {
            Hobby hobby = _context.Hobby.Find(id);
            if (hobby == null) {
                return NotFound();
            }
            return Ok(hobby);
        }
        [HttpPost]
        public IActionResult PostHobby(Hobby hobby) {
            _context.Hobby.Add(hobby);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHobby(int id) {
            Hobby hobby = _context.Hobby.Find(id);
            if (hobby == null) {
                return NotFound();
            }
            try {
                _context.Hobby.Remove(hobby);
                _context.SaveChanges();
            }
            catch (Exception ex) {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult PutHobby(Hobby hobby) {
            try {
                _context.Entry(hobby).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex) {
                return NotFound();
            }
            return Ok();
        }
    }
}

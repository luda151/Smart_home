using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Smart_home.Data;
using Smart_home.Models;

namespace Smart_home.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Teploties1Controller : ControllerBase
    {
        private readonly Smart_homeContext _context;

        public Teploties1Controller(Smart_homeContext context)
        {
            _context = context;
        }

        public Teploties1Controller()
        {
            ;
        }

        // GET: api/Teploties1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teploty>>> GetTeploty()
        {
            return await _context.Teploty.ToListAsync();
        }

        // GET: api/Teploties1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teploty>> GetTeploty(int id)
        {
            var teploty = await _context.Teploty.FindAsync(id);

            if (teploty == null)
            {
                return NotFound();
            }

            return teploty;
        }

        // PUT: api/Teploties1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeploty(int id, Teploty teploty)
        {
            if (id != teploty.id)
            {
                return BadRequest();
            }

            _context.Entry(teploty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeplotyExists(id))
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

        // POST: api/Teploties1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //public async Task<ActionResult<Teploty>> PostTeploty(Teploty teploty)
        public async void PostTeploty(Teploty teploty)

        {
            _context.Teploty.Add(teploty);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTeploty", new { id = teploty.id }, teploty);
        }

        // DELETE: api/Teploties1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeploty(int id)
        {
            var teploty = await _context.Teploty.FindAsync(id);
            if (teploty == null)
            {
                return NotFound();
            }

            _context.Teploty.Remove(teploty);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeplotyExists(int id)
        {
            return _context.Teploty.Any(e => e.id == id);
        }
    }
}

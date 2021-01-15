using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonVisController : ControllerBase
    {
        private readonly GiaoDucContext _context;

        public DonVisController(GiaoDucContext context)
        {
            _context = context;
        }

        // GET: api/DonVis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonVi>>> GetDonVis()
        {
            return await _context.DonVis.ToListAsync();
        }

        // GET: api/DonVis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DonVi>> GetDonVi(int id)
        {
            var donVi = await _context.DonVis.FindAsync(id);

            if (donVi == null)
            {
                return NotFound();
            }

            return donVi;
        }

        // PUT: api/DonVis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonVi(int id, DonVi donVi)
        {
            if (id != donVi.id)
            {
                return BadRequest();
            }

            _context.Entry(donVi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonViExists(id))
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

        // POST: api/DonVis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DonVi>> PostDonVi(DonVi donVi)
        {
            _context.DonVis.Add(donVi);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonVi", new { id = donVi.id }, donVi);
        }

        // DELETE: api/DonVis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonVi(int id)
        {
            var donVi = await _context.DonVis.FindAsync(id);
            if (donVi == null)
            {
                return NotFound();
            }

            _context.DonVis.Remove(donVi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DonViExists(int id)
        {
            return _context.DonVis.Any(e => e.id == id);
        }
    }
}

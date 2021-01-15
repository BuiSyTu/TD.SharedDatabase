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
    public class TruongHocsController : ControllerBase
    {
        private readonly GiaoDucContext _context;

        public TruongHocsController(GiaoDucContext context)
        {
            _context = context;
        }

        // GET: api/TruongHocs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TruongHoc>>> GetTruongHocs()
        {
            return await _context.TruongHocs.ToListAsync();
        }

        // GET: api/TruongHocs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TruongHoc>> GetTruongHoc(int id)
        {
            var truongHoc = await _context.TruongHocs.FindAsync(id);

            if (truongHoc == null)
            {
                return NotFound();
            }

            return truongHoc;
        }

        // PUT: api/TruongHocs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTruongHoc(int id, TruongHoc truongHoc)
        {
            if (id != truongHoc.id)
            {
                return BadRequest();
            }

            _context.Entry(truongHoc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TruongHocExists(id))
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

        // POST: api/TruongHocs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TruongHoc>> PostTruongHoc(TruongHoc truongHoc)
        {
            _context.TruongHocs.Add(truongHoc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTruongHoc", new { id = truongHoc.id }, truongHoc);
        }

        // DELETE: api/TruongHocs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTruongHoc(int id)
        {
            var truongHoc = await _context.TruongHocs.FindAsync(id);
            if (truongHoc == null)
            {
                return NotFound();
            }

            _context.TruongHocs.Remove(truongHoc);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TruongHocExists(int id)
        {
            return _context.TruongHocs.Any(e => e.id == id);
        }
    }
}

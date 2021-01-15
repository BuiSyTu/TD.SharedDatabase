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
    public class GiaoViensController : ControllerBase
    {
        private readonly GiaoDucContext _context;

        public GiaoViensController(GiaoDucContext context)
        {
            _context = context;
        }

        // GET: api/GiaoViens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GiaoVien>>> GetGiaoViens()
        {
            return await _context.GiaoViens.ToListAsync();
        }

        // GET: api/GiaoViens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GiaoVien>> GetGiaoVien(int id)
        {
            var giaoVien = await _context.GiaoViens.FindAsync(id);

            if (giaoVien == null)
            {
                return NotFound();
            }

            return giaoVien;
        }

        // PUT: api/GiaoViens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGiaoVien(int id, GiaoVien giaoVien)
        {
            if (id != giaoVien.id)
            {
                return BadRequest();
            }

            _context.Entry(giaoVien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GiaoVienExists(id))
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

        // POST: api/GiaoViens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GiaoVien>> PostGiaoVien(GiaoVien giaoVien)
        {
            _context.GiaoViens.Add(giaoVien);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGiaoVien", new { id = giaoVien.id }, giaoVien);
        }

        // DELETE: api/GiaoViens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGiaoVien(int id)
        {
            var giaoVien = await _context.GiaoViens.FindAsync(id);
            if (giaoVien == null)
            {
                return NotFound();
            }

            _context.GiaoViens.Remove(giaoVien);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GiaoVienExists(int id)
        {
            return _context.GiaoViens.Any(e => e.id == id);
        }
    }
}

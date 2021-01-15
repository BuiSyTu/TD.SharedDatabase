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
    public class HocSinhsController : ControllerBase
    {
        private readonly GiaoDucContext _context;

        public HocSinhsController(GiaoDucContext context)
        {
            _context = context;
        }

        // GET: api/HocSinhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HocSinh>>> GetHocSinhs()
        {
            return await _context.HocSinhs.ToListAsync();
        }

        // GET: api/HocSinhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HocSinh>> GetHocSinh(int id)
        {
            var hocSinh = await _context.HocSinhs.FindAsync(id);

            if (hocSinh == null)
            {
                return NotFound();
            }

            return hocSinh;
        }

        // PUT: api/HocSinhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHocSinh(int id, HocSinh hocSinh)
        {
            if (id != hocSinh.id)
            {
                return BadRequest();
            }

            _context.Entry(hocSinh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HocSinhExists(id))
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

        // POST: api/HocSinhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HocSinh>> PostHocSinh(HocSinh hocSinh)
        {
            _context.HocSinhs.Add(hocSinh);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHocSinh", new { id = hocSinh.id }, hocSinh);
        }

        // DELETE: api/HocSinhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHocSinh(int id)
        {
            var hocSinh = await _context.HocSinhs.FindAsync(id);
            if (hocSinh == null)
            {
                return NotFound();
            }

            _context.HocSinhs.Remove(hocSinh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HocSinhExists(int id)
        {
            return _context.HocSinhs.Any(e => e.id == id);
        }
    }
}

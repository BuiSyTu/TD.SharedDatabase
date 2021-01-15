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
    public class TinhThanhsController : ControllerBase
    {
        private readonly GiaoDucContext _context;

        public TinhThanhsController(GiaoDucContext context)
        {
            _context = context;
        }

        // GET: api/TinhThanhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TinhThanh>>> GetTinhThanhs()
        {
            return await _context.TinhThanhs.ToListAsync();
        }

        // GET: api/TinhThanhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TinhThanh>> GetTinhThanh(int id)
        {
            var tinhThanh = await _context.TinhThanhs.FindAsync(id);

            if (tinhThanh == null)
            {
                return NotFound();
            }

            return tinhThanh;
        }

        // PUT: api/TinhThanhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTinhThanh(int id, TinhThanh tinhThanh)
        {
            if (id != tinhThanh.id)
            {
                return BadRequest();
            }

            _context.Entry(tinhThanh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TinhThanhExists(id))
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

        // POST: api/TinhThanhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TinhThanh>> PostTinhThanh(TinhThanh tinhThanh)
        {
            _context.TinhThanhs.Add(tinhThanh);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTinhThanh", new { id = tinhThanh.id }, tinhThanh);
        }

        // DELETE: api/TinhThanhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTinhThanh(int id)
        {
            var tinhThanh = await _context.TinhThanhs.FindAsync(id);
            if (tinhThanh == null)
            {
                return NotFound();
            }

            _context.TinhThanhs.Remove(tinhThanh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TinhThanhExists(int id)
        {
            return _context.TinhThanhs.Any(e => e.id == id);
        }
    }
}

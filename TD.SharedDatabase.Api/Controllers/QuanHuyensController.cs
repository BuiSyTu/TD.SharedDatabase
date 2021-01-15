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
    public class QuanHuyensController : ControllerBase
    {
        private readonly GiaoDucContext _context;

        public QuanHuyensController(GiaoDucContext context)
        {
            _context = context;
        }

        // GET: api/QuanHuyens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuanHuyen>>> GetQuanHuyens()
        {
            return await _context.QuanHuyens.ToListAsync();
        }

        // GET: api/QuanHuyens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuanHuyen>> GetQuanHuyen(int id)
        {
            var quanHuyen = await _context.QuanHuyens.FindAsync(id);

            if (quanHuyen == null)
            {
                return NotFound();
            }

            return quanHuyen;
        }

        // PUT: api/QuanHuyens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuanHuyen(int id, QuanHuyen quanHuyen)
        {
            if (id != quanHuyen.id)
            {
                return BadRequest();
            }

            _context.Entry(quanHuyen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuanHuyenExists(id))
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

        // POST: api/QuanHuyens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<QuanHuyen>> PostQuanHuyen(QuanHuyen quanHuyen)
        {
            _context.QuanHuyens.Add(quanHuyen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuanHuyen", new { id = quanHuyen.id }, quanHuyen);
        }

        // DELETE: api/QuanHuyens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuanHuyen(int id)
        {
            var quanHuyen = await _context.QuanHuyens.FindAsync(id);
            if (quanHuyen == null)
            {
                return NotFound();
            }

            _context.QuanHuyens.Remove(quanHuyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuanHuyenExists(int id)
        {
            return _context.QuanHuyens.Any(e => e.id == id);
        }
    }
}

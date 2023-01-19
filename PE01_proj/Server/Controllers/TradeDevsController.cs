using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PE01_proj.Server.Data;
using PE01_proj.Shared.Domain;

namespace PE01_proj.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeDevsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TradeDevsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TradeDevs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TradeDev>>> GetTradeDevs()
        {
            return await _context.TradeDevs.ToListAsync();
        }

        // GET: api/TradeDevs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TradeDev>> GetTradeDev(int id)
        {
            var tradeDev = await _context.TradeDevs.FindAsync(id);

            if (tradeDev == null)
            {
                return NotFound();
            }

            return tradeDev;
        }

        // PUT: api/TradeDevs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTradeDev(int id, TradeDev tradeDev)
        {
            if (id != tradeDev.Id)
            {
                return BadRequest();
            }

            _context.Entry(tradeDev).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TradeDevExists(id))
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

        // POST: api/TradeDevs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TradeDev>> PostTradeDev(TradeDev tradeDev)
        {
            _context.TradeDevs.Add(tradeDev);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTradeDev", new { id = tradeDev.Id }, tradeDev);
        }

        // DELETE: api/TradeDevs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTradeDev(int id)
        {
            var tradeDev = await _context.TradeDevs.FindAsync(id);
            if (tradeDev == null)
            {
                return NotFound();
            }

            _context.TradeDevs.Remove(tradeDev);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TradeDevExists(int id)
        {
            return _context.TradeDevs.Any(e => e.Id == id);
        }
    }
}

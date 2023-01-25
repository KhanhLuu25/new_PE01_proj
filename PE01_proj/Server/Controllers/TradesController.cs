using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE01_proj.Server.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using PE01_proj.Server.Data;
using PE01_proj.Shared.Domain;

namespace PE01_proj.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TradesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Trades
        [HttpGet]
        public async Task<ActionResult> GetTrades()
        {
            var trades = await _unitOfWork.Trades.GetAll(includes: q => q.Include(x =>
x.Staffs).Include(x => x.Customers));
            return Ok(trades);
        }

        // GET: api/Trades/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetTrades(int id)
        {
            /*ContinueStatementSyntax from here*/
            var trades = await _unitOfWork.Trades.Get(q => q.Id == id);

            if (trades == null)
            {
                return NotFound();
            }

            return Ok(trades);
        }

        // PUT: api/Trades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrades(int id, Trade trade)
        {
            if (id != trade.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Trades.Update(trade);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TradesExists(id))
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

        // POST: api/Trades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Trade>> PostTrades(Trade trades)
        {
            await _unitOfWork.Trades.Insert(trades);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetTrades", new { id = trades.Id }, trades);
        }

        // DELETE: api/Trades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrades(int id)
        {
            var trades = await _unitOfWork.Trades.Get(q => q.Id == id);
            if (trades == null)
            {
                return NotFound();
            }

            await _unitOfWork.Trades.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> TradesExists(int id)
        {
            var trades = await _unitOfWork.Trades.Get(q => q.Id == id);
            return trades != null;
        }
    }
}

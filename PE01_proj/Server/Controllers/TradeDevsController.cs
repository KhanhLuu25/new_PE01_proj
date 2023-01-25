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
    public class TradeDevsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TradeDevsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/TradeDevs
        [HttpGet]
        public async Task<ActionResult> GetTradeDevs()
        {
            var tradeDevs = await _unitOfWork.TradeDevs.GetAll(includes: q => q.Include(x =>
x.Devices).Include(x => x.Customers));
            return Ok(tradeDevs);
        }

        // GET: api/TradeDevs/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetTradeDevs(int id)
        {
            /*ContinueStatementSyntax from here*/
            var tradeDevs = await _unitOfWork.TradeDevs.Get(q => q.Id == id);

            if (tradeDevs == null)
            {
                return NotFound();
            }

            return Ok(tradeDevs);
        }

        // PUT: api/TradeDevs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTradeDevs(int id, TradeDev tradeDev)
        {
            if (id != tradeDev.Id)
            {
                return BadRequest();
            }

            _unitOfWork.TradeDevs.Update(tradeDev);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await TradeDevsExists(id))
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
        public async Task<ActionResult<TradeDev>> PostTradeDevs(TradeDev tradeDevs)
        {
            await _unitOfWork.TradeDevs.Insert(tradeDevs);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetTradeDevs", new { id = tradeDevs.Id }, tradeDevs);
        }

        // DELETE: api/TradeDevs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTradeDevs(int id)
        {
            var tradeDevs = await _unitOfWork.TradeDevs.Get(q => q.Id == id);
            if (tradeDevs == null)
            {
                return NotFound();
            }

            await _unitOfWork.TradeDevs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> TradeDevsExists(int id)
        {
            var tradeDevs = await _unitOfWork.TradeDevs.Get(q => q.Id == id);
            return tradeDevs != null;
        }
    }
}

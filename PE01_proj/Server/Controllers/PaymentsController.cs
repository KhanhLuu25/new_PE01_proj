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
    public class PaymentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Payments
        [HttpGet]
        public async Task<ActionResult> GetPayments()
        {
            var payments = await _unitOfWork.Payments.GetAll();
            return Ok(payments);
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetPayments(int id)
        {
            /*ContinueStatementSyntax from here*/
            var payments = await _unitOfWork.Payments.Get(q => q.Id == id);

            if (payments == null)
            {
                return NotFound();
            }

            return Ok(payments);
        }

        // PUT: api/Payments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayments(int id, Payment payment)
        {
            if (id != payment.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Payments.Update(payment);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PaymentsExists(id))
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

        // POST: api/Payments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayments(Payment payments)
        {
            await _unitOfWork.Payments.Insert(payments);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPayments", new { id = payments.Id }, payments);
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayments(int id)
        {
            var payments = await _unitOfWork.Payments.Get(q => q.Id == id);
            if (payments == null)
            {
                return NotFound();
            }

            await _unitOfWork.Payments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PaymentsExists(int id)
        {
            var payments = await _unitOfWork.Payments.Get(q => q.Id == id);
            return payments != null;
        }
    }
}

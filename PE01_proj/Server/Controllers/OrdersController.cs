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
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrdersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult> GetOrders()
        {
            var orders = await _unitOfWork.Orders.GetAll();
            return Ok(orders);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetOrders(int id)
        {
            /*ContinueStatementSyntax from here*/
            var orders = await _unitOfWork.Orders.Get(q => q.Id == id);

            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrders(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Orders.Update(order);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrdersExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Device>> PostOrders(Order orders)
        {
            await _unitOfWork.Orders.Insert(orders);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOrders", new { id = orders.Id }, orders);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrders(int id)
        {
            var orders = await _unitOfWork.Orders.Get(q => q.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            await _unitOfWork.Orders.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> OrdersExists(int id)
        {
            var orders = await _unitOfWork.Orders.Get(q => q.Id == id);
            return orders != null;
        }
    }
}

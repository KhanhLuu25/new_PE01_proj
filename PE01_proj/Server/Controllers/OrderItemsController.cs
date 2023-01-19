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
    public class OrderItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/OrderItems
        [HttpGet]
        public async Task<ActionResult> GetOrderItems()
        {
            var orderItems = await _unitOfWork.OrderItems.GetAll();
            return Ok(orderItems);
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetOrderItems(int id)
        {
            /*ContinueStatementSyntax from here*/
            var orderItems = await _unitOfWork.OrderItems.Get(q => q.Id == id);

            if (orderItems == null)
            {
                return NotFound();
            }

            return Ok(orderItems);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItems(int id, OrderItem orderItem)
        {
            if (id != orderItem.Id)
            {
                return BadRequest();
            }

            _unitOfWork.OrderItems.Update(orderItem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrderItemsExists(id))
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

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItems(OrderItem orderItems)
        {
            await _unitOfWork.OrderItems.Insert(orderItems);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOrderItems", new { id = orderItems.Id }, orderItems);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItems(int id)
        {
            var orderItems = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            if (orderItems == null)
            {
                return NotFound();
            }

            await _unitOfWork.OrderItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> OrderItemsExists(int id)
        {
            var orderItems = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            return orderItems != null;
        }
    }
}

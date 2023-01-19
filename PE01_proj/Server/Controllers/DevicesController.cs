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
    public class DevicesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DevicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Devices
        [HttpGet]
        public async Task<ActionResult> GetDevices()
        {
            var devices = await _unitOfWork.Devices.GetAll();
            return Ok(devices);
        }

        // GET: api/Devices/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetDevices(int id)
        {
            /*ContinueStatementSyntax from here*/
            var devices = await _unitOfWork.Devices.Get(q => q.Id == id);

            if (devices == null)
            {
                return NotFound();
            }

            return Ok(devices);
        }

        // PUT: api/Devices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDevices(int id, Device device)
        {
            if (id != device.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Devices.Update(device);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await DevicesExists(id))
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

        // POST: api/Devices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Device>> PostDevices(Device devices)
        {
            await _unitOfWork.Devices.Insert(devices);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDevices", new { id = devices.Id }, devices);
        }

        // DELETE: api/Devices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDevices(int id)
        {
            var devices = await _unitOfWork.Devices.Get(q => q.Id ==id);
            if (devices == null)
            {
                return NotFound();
            }

            await _unitOfWork.Devices.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> DevicesExists(int id)
        {
            var devices = await _unitOfWork.Devices.Get(q => q.Id == id);
            return devices != null;
        }
    }
}

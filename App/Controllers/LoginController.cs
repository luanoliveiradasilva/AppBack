using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Controllers.Repository;
using App.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;

        public LoginController(ILoginRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var clientes = await _repository.GetClientesAsync();
            return Ok(clientes);
        }

       /*  // GET: api/Login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _repository.GetClienteByIdAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        // POST: api/Login
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            await _repository.AddClienteAsync(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = cliente.EmpId }, cliente);
        }

        // PUT: api/Login/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.EmpId)
            {
                return BadRequest();
            }

            try
            {
                await _repository.UpdateClienteAsync(cliente);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _repository.ClienteExistsAsync(id))
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

        // DELETE: api/Login/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var clienteExists = await _repository.ClienteExistsAsync(id);
            if (!clienteExists)
            {
                return NotFound();
            }

            await _repository.DeleteClienteAsync(id);

            return NoContent();
        } */
    }
}

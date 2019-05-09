using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCrud.Models;
using WebApiCrud.Services;

namespace WebApiCrud.Controllers.API
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesApiController : ControllerBase
    {
        private readonly ClienteService _context;
        public ClientesApiController(ClienteService context)
        {
            _context = context;
        }

        // GET: api/ClientesApi
        [HttpGet]
        public IEnumerable<Cliente> GetClientes()
        {
            return _context.Get();
        }      

        // GET: api/ClientesApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCliente([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = _context.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        // PUT: api/ClientesApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente([FromRoute] string id, Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _context.Update(id, cliente);

            return NoContent();
        }

        // POST: api/ClientesApi
        [HttpPost]
        public async Task<IActionResult> PostCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Create(cliente);

            return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
        }

        // DELETE: api/ClientesApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(string id)
        {
            var cliente = _context.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }

            _context.Remove(cliente.Id);


            return Ok(cliente);
        }
    }
}
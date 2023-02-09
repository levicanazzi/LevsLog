using ApiLevsLog.Data;
using ApiLevsLog.Mapper;
using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.ClienteDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLevsLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ClienteController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            List<Cliente> clientes = await _dbContext.Clientes.Include("Endereco").ToListAsync();

            if (clientes.Count == 0)
            {
                return NotFound();
            }

            var clientesDto = ClienteProfile.ClientesToReadClientes(clientes);

            return Ok(clientesDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCliente(int id)
        {
            Cliente cliente = await _dbContext.Clientes.Include("Endereco").FirstOrDefaultAsync(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            var clientDto = ClienteProfile.ReadClienteById(cliente);

            return Ok(clientDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddCliente([FromBody] AddCliente clienteDto)
        {
            var cliente = ClienteProfile.AddClientes(clienteDto);

            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();

            var readCliente = ClienteProfile.ReadClienteById(cliente);

            return CreatedAtAction(nameof(GetCliente), new { id = readCliente.Id }, readCliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpCliente(int id, [FromBody] UpdateCliente clienteDto)
        {
            var cliente = await _dbContext.Clientes.Include("Endereco").FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            cliente = ClienteProfile.UpdateClientes(clienteDto, cliente);

            await _dbContext.SaveChangesAsync();

            var clienteReadDto = ClienteProfile.ReadClienteById(cliente);

            return Ok(clienteReadDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarCliente(int id)
        {
            Cliente cliente = await _dbContext.Clientes.Include("Orcamentos").FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            if (cliente.Orcamentos.Count > 0)
            {
                return BadRequest("O cliente possui orçamentos em aberto.");
            }

            return Ok();
        }

    }
}

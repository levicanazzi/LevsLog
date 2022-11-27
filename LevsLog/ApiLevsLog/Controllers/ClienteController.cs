using ApiLevsLog.Data;
using ApiLevsLog.Models;
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
            List<Cliente> clientes = await _dbContext.Clientes.ToListAsync();

            if (clientes.Count == 0)
            {
                return NotFound();
            }

            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCliente(int id)
        {
            Cliente cliente = await _dbContext.Clientes.FirstOrDefaultAsync(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> AddCliente([FromBody] Cliente cliente)
        {
            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpCliente(int id, [FromBody] Cliente clienteDto)
        {
            Cliente cliente = await _dbContext.Clientes.Include("Endereco").FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            cliente.Nome = clienteDto.Nome;
            cliente.Sobrenome = clienteDto.Sobrenome;
            cliente.Endereco.Logradouro = clienteDto.Endereco.Logradouro;
            cliente.Endereco.Numero = clienteDto.Endereco.Numero;
            cliente.Endereco.Cep = clienteDto.Endereco.Cep;
            cliente.Endereco.Municipio = clienteDto.Endereco.Municipio;
            cliente.Endereco.Estado = clienteDto.Endereco.Estado;
            cliente.Email = clienteDto.Email;

            await _dbContext.SaveChangesAsync();

            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarCliente(int id)
        {
            Cliente cliente = await _dbContext.Clientes.FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            _dbContext.Remove(cliente);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}

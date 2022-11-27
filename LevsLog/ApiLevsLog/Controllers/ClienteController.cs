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
        public async Task<IActionResult> AddCliente([FromBody] Cliente cliente)
        {
            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();

            var clienteDto = ClienteProfile.AddClientes(cliente);

            return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, clienteDto);
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

            var clienteDto2 = ClienteProfile.UpdateClientes(cliente);

            await _dbContext.SaveChangesAsync();

            return Ok(clienteDto2);
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

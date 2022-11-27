using ApiLevsLog.Data;
using ApiLevsLog.Mapper;
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
    public class EnderecoController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public EnderecoController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEnderecos()
        {
            List<Enderecos> enderecos = await _dbContext.Enderecos.Include("Cliente").ToListAsync();

            if (enderecos.Count == 0)
            {
                return NotFound();
            }

            var enderecosDto = EnderecoProfile.EnderecosToReadEnderecos(enderecos);

            return Ok(enderecosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEndereco(int id)
        {
            Enderecos endereco = await _dbContext.Enderecos.Include("Cliente").FirstOrDefaultAsync(e => e.Id == id);

            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        [HttpPost]
        public async Task<IActionResult> AddEndereco([FromBody] Enderecos endereco)
        {
            await _dbContext.Enderecos.AddAsync(endereco);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEndereco), new { id = endereco.Id }, endereco);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpEndereco(int id, [FromBody] Enderecos enderecoDto)
        {
            Enderecos endereco = await _dbContext.Enderecos.FirstOrDefaultAsync(x => x.Id == id);

            if (endereco == null)
            {
                return NotFound();
            }

            endereco.Logradouro = enderecoDto.Logradouro;
            endereco.Numero = enderecoDto.Numero;
            endereco.Cep = enderecoDto.Cep;
            endereco.Municipio = enderecoDto.Municipio;
            endereco.Estado = enderecoDto.Estado;

            await _dbContext.SaveChangesAsync();

            return Ok(endereco);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarEndereco(int id)
        {
            Enderecos endereco = await _dbContext.Enderecos.FirstOrDefaultAsync(x => x.Id == id);

            if (endereco == null)
            {
                return NotFound();
            }

            _dbContext.Remove(endereco);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}

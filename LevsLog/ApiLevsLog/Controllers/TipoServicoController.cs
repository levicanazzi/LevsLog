using ApiLevsLog.Data;
using ApiLevsLog.Mapper;
using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.TipoServico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLevsLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoServicoController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public TipoServicoController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetTipoServico()
        {
            List<TipoServico> tipoServicos = await _dbContext.TipoServicos.ToListAsync();

            if (tipoServicos.Count == 0)
            {
                return NotFound();
            }

            var tipoServicosDto = TipoServicoProfile.ReadTipoServicos(tipoServicos);

            return Ok(tipoServicosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoServicoById(int id)
        {
            TipoServico tipoServico = await _dbContext.TipoServicos.FirstOrDefaultAsync(e => e.Id == id);

            if (tipoServico == null)
            {
                return NotFound();
            }

            var tipoServicoDto = TipoServicoProfile.ReadTipoServicoById(tipoServico);

            return Ok(tipoServicoDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddTipoServico([FromBody] AddTipoServico tipoServicoDto)
        {
            var tipoServico = TipoServicoProfile.AddTipoServico(tipoServicoDto);

            await _dbContext.TipoServicos.AddAsync(tipoServico);
            await _dbContext.SaveChangesAsync();

            var readTipoServicoDto = TipoServicoProfile.ReadTipoServicoById(tipoServico);
            return CreatedAtAction(nameof(GetTipoServico), new { id = readTipoServicoDto.Id }, readTipoServicoDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTipoServico(int id, [FromBody] UpdateTipoServico tipoServicoDto)
        {
            var tipoServico = await _dbContext.TipoServicos.FirstOrDefaultAsync(x => x.Id == id);

            if (tipoServico == null)
            {
                NotFound();
            }

            tipoServico = TipoServicoProfile.UpdateTipoServico(tipoServicoDto, tipoServico);

            await _dbContext.SaveChangesAsync();

            var readTipoServicoDto = TipoServicoProfile.ReadTipoServicoById(tipoServico);

            return Ok(readTipoServicoDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarTipoServico(int id)
        {
            var tipoServico = await _dbContext.TipoServicos.FirstOrDefaultAsync(x => x.Id == id);

            if (tipoServico == null)
            {
                NotFound();
            }

            _dbContext.Remove(tipoServico);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}

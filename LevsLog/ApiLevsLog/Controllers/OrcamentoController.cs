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
    public class OrcamentoController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public OrcamentoController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrcamento()
        {
            List<Orcamento> orcamentos = await _dbContext.Orcamentos
                .Include("Cliente")
                .Include("Endereco")
                .Include("TipoServico")
                .Include("Produtos").ToListAsync();

            if (orcamentos.Count == 0)
            {
                return NotFound();
            }

            var orcamentosDto = OrcamentoProfile.OrcamentosToReadOrcamentos(orcamentos);

            return Ok(orcamentosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrcamentoById(int id)
        {
            Orcamento orcamento = await _dbContext.Orcamentos
                .Include("Cliente")
                .Include("Endereco")
                .Include("TipoServico")
                .Include("Produtos")
                .FirstOrDefaultAsync(c => c.Id == id);

            if (orcamento == null)
            {
                return NotFound();
            }

            var orcamentoDto = OrcamentoProfile.ReadOrcamentoById(orcamento);

            return Ok(orcamentoDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrcamento([FromBody] Orcamento orcamento)
        {
            await _dbContext.Orcamentos.AddAsync(orcamento);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrcamento), new { id = orcamento.Id }, orcamento);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarOrcamento(int id)
        {
            Orcamento orcamento = await _dbContext.Orcamentos.FirstOrDefaultAsync(x => x.Id == id);

            if (orcamento == null)
            {
                return NotFound();
            }

            _dbContext.Remove(orcamento);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
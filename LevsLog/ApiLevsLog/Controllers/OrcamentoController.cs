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
                .Include("Enderecos")
                .Include("TipoServico")
                .Include("Produto").ToListAsync();

            if (orcamentos.Count == 0)
            {
                return NotFound();
            }

            var orcamentosDto = OrcamentoProfile.OrcamentosToReadOrcamentos(orcamentos);

            return Ok(orcamentosDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrcamento([FromBody] Orcamento orcamento)
        {
            await _dbContext.Orcamentos.AddAsync(orcamento);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrcamento), new { id = orcamento.Id }, orcamento);
        }
    }
}
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

            var tipoServicosDto = TipoServicoProfile.ReadingTipoServicos(tipoServicos);

            return Ok(tipoServicosDto);
        }
    }
}

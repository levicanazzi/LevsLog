using ApiLevsLog.Data;
using ApiLevsLog.Mapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ApiLevsLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ProdutoController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProdutos()
        {
            var produtos = await _dbContext.Produtos
                .Include("Orcamento")
                .ToListAsync();

            if (produtos.Count == 0)
            {
                NotFound();
            }

            var produtosDto = ProdutoProfile.ProdutosToReadProdutos(produtos);

            return Ok(produtosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProdutoById(int id)
        {
            var produto = await _dbContext.Produtos.Include("Orcamento").FirstOrDefaultAsync(x => x.Id == id);

            if (produto == null)
            {
                NotFound();
            }

            var produtoDto = ProdutoProfile.ReadProdutoById(produto);

            return Ok(produtoDto);
        }
    }
}

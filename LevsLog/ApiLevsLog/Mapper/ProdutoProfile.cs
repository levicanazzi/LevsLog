using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.ProdutoDtos;
using System.Collections.Generic;

namespace ApiLevsLog.Mapper
{
    public class ProdutoProfile
    {
        public static List<ReadProduto> ProdutosToReadProdutos(List<Produto> produtos)
        {
            List<ReadProduto> produtosDto = new List<ReadProduto>();

            foreach (var prod in produtos)
            {
                produtosDto.Add(new ReadProduto()
                {
                    Id = prod.Id,
                    IdOrcamento = prod.IdOrcamento,
                    Altura = prod.Altura,
                    Largura = prod.Largura,
                    Comprimento = prod.Comprimento,
                    Peso = prod.Peso
                });
            }

            return produtosDto;
        }
    }
}

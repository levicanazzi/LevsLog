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

        public static ReadProduto ReadProdutoById(Produto produto)
        {
            ReadProduto produtoDto = new ReadProduto();

            produtoDto.Id = produto.Id;
            produtoDto.IdOrcamento = produto.IdOrcamento;
            produtoDto.Altura = produto.Altura;
            produtoDto.Largura = produto.Largura;
            produtoDto.Comprimento = produto.Comprimento;
            produtoDto.Peso = produto.Peso;

            return produtoDto;
        }

        public static Produto AddProduto(AddProduto produtoDto)
        {
            Produto produto = new Produto()
            {
                IdOrcamento = produtoDto.IdOrcamento,
                Altura = produtoDto.Altura,
                Largura = produtoDto.Largura,
                Comprimento = produtoDto.Comprimento,
                Peso = produtoDto.Peso
            };

            return produto;
        }
    }
}

using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.OrcamentoDtos;
using ApiLevsLog.Models.Dtos.ProdutoDtos;
using System.Collections.Generic;

namespace ApiLevsLog.Mapper
{
    public class OrcamentoProfile
    {
        public static List<ReadOrcamento> OrcamentosToReadOrcamentos(List<Orcamento> orcamentos)
        {
            List<ReadOrcamento> orcamentosDto = new List<ReadOrcamento>();

            foreach (var orcamento in orcamentos)
            {
                List<ProdutoOrcamentoDto> produtos = new List<ProdutoOrcamentoDto>();
                foreach (var prod in orcamento.Produtos)
                {
                    produtos.Add(new ProdutoOrcamentoDto()
                    {
                        Altura = prod.Altura,
                        Largura = prod.Largura,
                        Comprimento = prod.Comprimento,
                        Peso = prod.Peso
                    });
                }

                orcamentosDto.Add(new ReadOrcamento()
                {
                    Id = orcamento.Id,
                    Valor = orcamento.Valor,
                    IdCliente = orcamento.Cliente.Id,
                    Nome = orcamento.Cliente.Nome,
                    Sobrenome = orcamento.Cliente.Sobrenome,
                    Email = orcamento.Cliente.Email,
                    DataNascimento = orcamento.Cliente.DataNascimento,
                    IdTipoServico = orcamento.IdTipoServico,
                    Servico = orcamento.TipoServico.Servico,
                    IdEndereco = orcamento.IdEndereco,
                    Logradouro = orcamento.Endereco.Logradouro,
                    Numero = orcamento.Endereco.Numero,
                    Cep = orcamento.Endereco.Cep,
                    Municipio = orcamento.Endereco.Municipio,
                    Estado = orcamento.Endereco.Estado,
                    ProdutoDto = produtos
                });

            }

            return orcamentosDto;
        }
        public static ReadOrcamento ReadOrcamentoById(Orcamento orcamento)
        {
            ReadOrcamento orcamentoDto = new ReadOrcamento();

            orcamentoDto.Id = orcamento.Id;
            orcamentoDto.Valor = orcamento.Valor;
            orcamentoDto.IdCliente = orcamento.Cliente.Id;
            orcamentoDto.Nome = orcamento.Cliente.Nome;
            orcamentoDto.Sobrenome = orcamento.Cliente.Sobrenome;
            orcamentoDto.Email = orcamento.Cliente.Email;
            orcamentoDto.DataNascimento = orcamento.Cliente.DataNascimento;
            orcamentoDto.IdEndereco = orcamento.IdEndereco;
            orcamentoDto.Logradouro = orcamento.Endereco.Logradouro;
            orcamentoDto.Numero = orcamento.Endereco.Numero;
            orcamentoDto.Cep = orcamento.Endereco.Cep;
            orcamentoDto.Municipio = orcamento.Endereco.Municipio;
            orcamentoDto.Estado = orcamento.Endereco.Estado;
            orcamentoDto.IdTipoServico = orcamento.IdTipoServico;
            orcamentoDto.Servico = orcamento.TipoServico.Servico;

            List<ProdutoOrcamentoDto> produtos = new List<ProdutoOrcamentoDto>();
            foreach (var prod in orcamento.Produtos)
            {
                produtos.Add(new ProdutoOrcamentoDto()
                {
                    Altura = prod.Altura,
                    Largura = prod.Largura,
                    Comprimento = prod.Comprimento,
                    Peso = prod.Peso
                });
            }
            orcamentoDto.ProdutoDto = produtos;

            return orcamentoDto;
        }
        public static Orcamento AddOrcamento(AddOrcamento orcamentoDto)
        {
            Enderecos enderecos = new Enderecos()
            {

                Logradouro = orcamentoDto.Logradouro,
                Numero = orcamentoDto.Numero,
                Cep = orcamentoDto.Cep,
                Municipio = orcamentoDto.Municipio,
                Estado = orcamentoDto.Estado
            };

            List<Produto> produtos = new List<Produto>();
            foreach (var prod in orcamentoDto.Produtos)
            {
                produtos.Add(new Produto()
                {
                    Altura = prod.Altura,
                    Largura = prod.Largura,
                    Peso = prod.Peso,
                    Comprimento = prod.Comprimento
                });
            }

            Orcamento orcamento = new Orcamento()
            {
                Id = orcamentoDto.Id,
                IdCliente = orcamentoDto.IdCliente,
                IdTipoServico = orcamentoDto.IdTipoServico,
                Valor = orcamentoDto.Valor,
                Endereco = enderecos,
                Produtos = produtos
            };

            return orcamento;
        }
        public static Orcamento UpdateOrcamentos(UpdateOrcamento orcamentoDto, Orcamento orcamento)
        {
            orcamento.Valor = orcamentoDto.Valor;
            orcamento.IdTipoServico = orcamentoDto.IdTipoServico;
            orcamento.Cliente.Nome = orcamentoDto.Nome;
            orcamento.Cliente.Sobrenome = orcamentoDto.Sobrenome;
            orcamento.Cliente.Email = orcamentoDto.Email;
            orcamento.Endereco.Logradouro = orcamentoDto.Logradouro;
            orcamento.Endereco.Numero = orcamentoDto.Numero;
            orcamento.Endereco.Cep = orcamentoDto.Cep;
            orcamento.Endereco.Municipio = orcamentoDto.Municipio;
            orcamento.Endereco.Estado = orcamentoDto.Estado;

            return orcamento;
        }
    }
}

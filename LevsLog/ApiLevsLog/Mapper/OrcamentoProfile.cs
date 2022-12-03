using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.OrcamentoDtos;
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
                orcamentosDto.Add(new ReadOrcamento()
                {
                    Id = orcamento.Id,
                    Valor = orcamento.Valor,
                    IdCliente = orcamento.IdCliente,
                    Nome = orcamento.Cliente.Nome,
                    Sobrenome = orcamento.Cliente.Sobrenome,
                    Email = orcamento.Cliente.Email,
                    IdTipoServico = orcamento.IdTipoServico,
                    Servico = orcamento.TipoServico.Servico,
                    IdEndereco = orcamento.IdEndereco,
                    Logradouro = orcamento.Endereco.Logradouro,
                    Numero = orcamento.Endereco.Numero,
                    Cep = orcamento.Endereco.Cep,
                    Municipio = orcamento.Endereco.Municipio,
                    Estado = orcamento.Endereco.Estado

                });
            }

            return orcamentosDto;
        }
        public static ReadOrcamento ReadOrcamentoById(Orcamento orcamento)
        {
            ReadOrcamento orcamentoDto = new ReadOrcamento();

            orcamentoDto.Id = orcamento.Id;
            orcamentoDto.Valor = orcamento.Valor;
            orcamentoDto.IdCliente = orcamento.IdCliente;
            orcamentoDto.Nome = orcamento.Cliente.Nome;
            orcamentoDto.Sobrenome = orcamento.Cliente.Sobrenome;
            orcamentoDto.Email = orcamento.Cliente.Email;
            orcamentoDto.IdEndereco = orcamento.IdEndereco;
            orcamentoDto.Logradouro = orcamento.Endereco.Logradouro;
            orcamentoDto.Numero = orcamento.Endereco.Numero;
            orcamentoDto.Cep = orcamento.Endereco.Cep;
            orcamentoDto.Municipio = orcamento.Endereco.Municipio;
            orcamentoDto.Estado = orcamento.Endereco.Estado;
            orcamentoDto.IdTipoServico = orcamento.IdTipoServico;
            orcamentoDto.Servico = orcamento.TipoServico.Servico;

            return orcamentoDto;
        }
    }
}

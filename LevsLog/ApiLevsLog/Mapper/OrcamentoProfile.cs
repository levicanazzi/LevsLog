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
                    IdCliente = orcamento.IdCliente,
                    IdEndereco = orcamento.IdEndereco,
                    IdTipoServico = orcamento.IdTipoServico,
                    Valor = orcamento.Valor,
                    Nome = orcamento.Cliente.Nome,
                    Sobrenome = orcamento.Cliente.Sobrenome,
                    Email = orcamento.Cliente.Email,
                    Servico = orcamento.TipoServico.Servico,
                    Logradouro = orcamento.Endereco.Logradouro,
                    Numero = orcamento.Endereco.Numero,
                    Cep = orcamento.Endereco.Cep,
                    Municipio = orcamento.Endereco.Municipio,
                    Estado = orcamento.Endereco.Estado
                });
            }

            return orcamentosDto;
        }
    }
}

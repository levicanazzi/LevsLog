using ApiLevsLog.Models.Dtos.ProdutoDtos;
using System;
using System.Collections.Generic;

namespace ApiLevsLog.Models.Dtos.OrcamentoDtos
{
    public class ReadOrcamento
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public int IdTipoServico { get; set; }
        public string Servico { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int IdEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public List<ProdutoOrcamentoDto> ProdutoDto { get; set; }
    }
}

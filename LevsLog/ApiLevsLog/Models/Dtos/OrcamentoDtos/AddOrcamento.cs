using ApiLevsLog.Models.Dtos.ProdutoDtos;
using System.Collections.Generic;

namespace ApiLevsLog.Models.Dtos.OrcamentoDtos
{
    public class AddOrcamento
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoServico { get; set; }
        public int IdEndereco { get; set; }
        public double Valor { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public List<ProdutoOrcamentoDto> ProdutoDto { get; set; }
    }
}

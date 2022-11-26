using System.Collections.Generic;

namespace ApiLevsLog.Models
{
    public class Orcamento
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public Cliente Cliente { get; set; }
        public TipoServico TipoServiço { get; set; }
        public Enderecos Endereco { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
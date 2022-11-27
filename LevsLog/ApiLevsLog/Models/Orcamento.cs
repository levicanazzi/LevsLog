using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiLevsLog.Models
{
    public class Orcamento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdTipoServico { get; set; }
        [Required]
        public int IdEndereco { get; set; }
        public double Valor { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual TipoServico TipoServico { get; set; }
        public virtual Enderecos Endereco { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
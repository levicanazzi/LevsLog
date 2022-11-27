using System.ComponentModel.DataAnnotations;

namespace ApiLevsLog.Models
{
    public class TipoServico
    {
        [Key]
        public int Id { get; set; }
        public string Servico { get; set; }
        public virtual Orcamento Orcamento { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace ApiLevsLog.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdOrcamento { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Peso { get; set; }
        public virtual Orcamento Orcamento { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace ApiLevsLog.Models
{
    public class Enderecos
    {
        [Key]
        public int Id { get; set; }        
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }        
        public virtual Orcamento Orcamento { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
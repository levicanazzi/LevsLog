using System.Collections.Generic;

namespace ApiLevsLog.Models
{
    public class Enderecos
    {
        public int Id { get; set; }        
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public int Cep { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }        
        public Orcamento Orcamento { get; set; }
        public Cliente Clientes { get; set; }
    }
}
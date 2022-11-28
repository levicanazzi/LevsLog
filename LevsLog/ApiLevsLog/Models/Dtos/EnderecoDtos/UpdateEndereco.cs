using System;

namespace ApiLevsLog.Models.Dtos.EnderecoDtos
{
    public class UpdateEndereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
    }
}


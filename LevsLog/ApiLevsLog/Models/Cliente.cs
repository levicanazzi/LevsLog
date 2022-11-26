using System;
using System.Collections.Generic;

namespace ApiLevsLog.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Enderecos Endereco { get; set; }
        public List<Orcamento> Orcamentos { get; set; }
    }
}
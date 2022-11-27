using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiLevsLog.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdEndereco { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual Enderecos Endereco { get; set; }
        public virtual List<Orcamento> Orcamentos { get; set; }
    }
}
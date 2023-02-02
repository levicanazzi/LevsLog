using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace LevsLogAppWebForms.Models
{
    public class Orcamentos
    {
        public int IdCliente { get; set; }
        public int IdTipoServico { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public double Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
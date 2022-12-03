namespace ApiLevsLog.Models.Dtos.OrcamentoDtos
{
    public class AddOrcamento
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoServico { get; set; }
        public int IdEndereco { get; set; }
        public double Valor { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Servico { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
    }
}

namespace ApiLevsLog.Models
{
    public class TipoServico
    {
        public int Id { get; set; }
        public string Servico { get; set; }
        public Orcamento Orcamento { get; set; }
    }
}
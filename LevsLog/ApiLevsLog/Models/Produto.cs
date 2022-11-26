namespace ApiLevsLog.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Peso { get; set; }
        public Orcamento Orcamento { get; set; }
    }
}
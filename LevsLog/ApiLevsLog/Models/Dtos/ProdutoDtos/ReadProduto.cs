namespace ApiLevsLog.Models.Dtos.ProdutoDtos
{
    public class ReadProduto
    {
        public int Id { get; set; }
        public int IdOrcamento { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Peso { get; set; }
    }
}

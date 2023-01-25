using LevsLogAppWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LevsLogAppWebForms
{
    public partial class Orcamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Produto> produtos = new List<Produto>();
                Session["Produtos"] = produtos;
            }
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(TxtIdCliente.Text);
            int idTipoServico = int.Parse(TxtTipoServico.Text);
            string endereco = TxtEndereco.Text;
            string numero = TxtNumero.Text;
            string cep = TxtCep.Text;
            string municipio = TxtMunicipio.Text;
            string estado = TxtEstado.Text;
            double largura = double.Parse(TxtLargura.Text);
            double altura = double.Parse(TxtAltura.Text);
            double comprimento = double.Parse(TxtComprimento.Text);
            double peso = double.Parse(TxtPeso.Text);

            Orcamentos orcamento = new Orcamentos()
            {
                IdCliente = idCliente,
                IdTipoServico = idTipoServico,
                Endereco = endereco,
                Numero = numero,
                Cep = cep,
                Estado = estado,
                Municipio = municipio,
                Altura = altura,
                Largura = largura,
                Comprimento = comprimento,
                Peso = peso
            };
        }

        protected void BtnAdicionarProduto_Click(object sender, EventArgs e)
        {
            string nome = TxtNomeProduto.Text;
            double largura = double.Parse(TxtLargura.Text);
            double altura = double.Parse(TxtAltura.Text);
            double comprimento = double.Parse(TxtComprimento.Text);
            double peso = double.Parse(TxtPeso.Text);

            Produto produto = new Produto()
            {
                Nome = nome,
                Largura = largura,
                Altura = altura,
                Comprimento = comprimento,
                Peso = peso
            };

            var lstProdutos = (List<Produto>)Session["Produtos"];
            lstProdutos.Add(produto);
            Session["Produtos"] = lstProdutos;

            GvProdutos.DataSource = lstProdutos;
            GvProdutos.DataBind();
            
        }
    }
}
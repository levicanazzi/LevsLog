using LevsLogAppWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LevsLogAppWebForms
{
    public partial class Cadastro : System.Web.UI.Page
    {
        private readonly Api api = new Api();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
            string sobrenome = TxtSobrenome.Text;
            DateTime dataNascimento = DateTime.Parse(TxtDataNascimento.Text);
            string email = TxtEmail.Text;
            string endereco = TxtEndereco.Text;
            string numero = TxtNumero.Text;
            string cep = TxtCep.Text;
            string municipio = TxtMunicipio.Text;
            string estado = TxtEstado.Text;


            Cliente cliente = new Cliente()
            {
                Nome = nome,
                Sobrenome = sobrenome,
                DataNascimento = dataNascimento,
                Email = email,
                Logradouro = endereco,
                Numero = numero,
                Cep = cep,
                Municipio = municipio,
                Estado = estado
            };

            try
            {
                api.PostCliente(cliente, HttpMethod.Post);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
using LevsLogAppWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
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
            if (!IsPostBack)
            {
                string sParams = Request.QueryString["cliente"];
                HdnIdCliente.Value = sParams;

                if (!string.IsNullOrEmpty(sParams))
                {
                    CarregarClienteParaUpdate();

                    SwitchTela("Edit");
                }
            }
        }

        private void SwitchTela(string tela)
        {
            if (tela == "Edit")
            {
                BtnEditar.Visible = true;
                BtnCadastrar.Visible = false;
                Titulo.Text = "Atualizar Cliente";
            }
            else
            {
                BtnEditar.Visible = false;
                BtnCadastrar.Visible = true;
                Titulo.Text = "Cadastrar Cliente";
            }
        }

        #region CadastroNovo
        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = GerarCliente();

            try
            {
                api.PostCliente(cliente, HttpMethod.Post);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            Response.Redirect("clientes.aspx");
        }
        #endregion

        #region Update
        private async void CarregarClienteParaUpdate()
        {
            int idCliente = int.Parse(HdnIdCliente.Value);
            Cliente cliente = await api.GetCliente(idCliente);

            TxtNome.Text = cliente.Nome;
            TxtSobrenome.Text = cliente.Sobrenome;
            TxtDataNascimento.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
            TxtEmail.Text = cliente.Email;
            TxtEndereco.Text = cliente.Logradouro;
            TxtNumero.Text = cliente.Numero;
            TxtCep.Text = cliente.Cep;
            TxtMunicipio.Text = cliente.Municipio;
            TxtEstado.Text = cliente.Estado;
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(HdnIdCliente.Value);
            Cliente cliente = GerarCliente();         

            api.PutCliente(idCliente, cliente, HttpMethod.Put);

            Response.Redirect("clientes.aspx");
        }

        #endregion

        protected Cliente GerarCliente()
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

            return cliente;
        }
    }
}
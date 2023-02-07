using LevsLogAppWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LevsLogAppWebForms
{
    public partial class Clientes : System.Web.UI.Page
    {
        private readonly Api api = new Api();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarClientes();
            }
        }

        protected async void CarregarClientes()
        {
            List<Cliente> clientes = await api.GetClientes();

            GvClientes.DataSource = clientes;
            GvClientes.DataBind();
        }

        protected void BtnEditCliente_Command(object sender, CommandEventArgs e)
        {
            int idCliente = int.Parse(e.CommandArgument.ToString());

            Response.Redirect($"Cadastro.aspx?cliente={idCliente}");
        }

        protected void BtnExcluirCliente_Command(object sender, CommandEventArgs e)
        {

        }
    }
}
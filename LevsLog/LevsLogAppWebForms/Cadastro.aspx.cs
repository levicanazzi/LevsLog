using LevsLogAppWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LevsLogAppWebForms
{
    public partial class Cadastro : System.Web.UI.Page
    {
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
                Nome= nome,
                Sobrenome= sobrenome,
                DataNascimento= dataNascimento,
                Email = email,
                Endereco = endereco,
                Numero = numero,
                Cep = cep,
                Municipio = municipio,
                Estado = estado
            };

            // montar o json e enviar pra api
        }
    }
}
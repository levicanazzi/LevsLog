﻿using LevsLogAppWebForms.Models;
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

            Cliente cliente = new Cliente()
            {
                Nome= nome,
                Sobrenome= sobrenome,
                DataNascimento= dataNascimento
            };

            // montar o json e enviar pra api
        }
    }
}
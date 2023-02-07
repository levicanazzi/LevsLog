<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" Async="true" CodeBehind="Cadastro.aspx.cs" Inherits="LevsLogAppWebForms.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 class="text-center"><asp:Literal ID="Titulo" runat="server">Cadastre o Cliente</asp:Literal></h3>
        <div class="row mt-4">
            <div class="col-md-3">
                <div class="input-group col mb-3">
                    <span class="input-group-text" id="TxtNome">Nome</span>
                    <asp:TextBox ID="TxtNome" runat="server" CssClass="form-control" placeholder="Primeiro Nome" aria-label="First name" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtSobrenome">Sobrenome</span>
                    <asp:TextBox ID="TxtSobrenome" runat="server" CssClass="form-control" placeholder="Sobrenome" aria-label="Last Name" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtEmail">Email</span>
                    <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" placeholder="Email" aria-label="Email" />
                </div>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtDataNascimento">Data de Nascimento</span>
                    <asp:TextBox ID="TxtDataNascimento" runat="server" CssClass="form-control" placeholder="Data de Nascimento" aria-label="Data de Nascimento" />
                </div>
            </div>
            <div class="col-md-5">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtEndereco">Endereço</span>
                    <asp:TextBox ID="TxtEndereco" runat="server" CssClass="form-control" placeholder="Endereço" aria-label="Endereco" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtNumero">Numero</span>
                    <asp:TextBox ID="TxtNumero" runat="server" CssClass="form-control" placeholder="Numero" aria-label="Numero" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtCep">CEP</span>
                    <asp:TextBox ID="TxtCep" runat="server" CssClass="form-control" placeholder="CEP" aria-label="Cep" />
                </div>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtEstado">Estado</span>
                    <asp:TextBox ID="TxtEstado" runat="server" CssClass="form-control" placeholder="Estado" aria-label="Estado" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtMunicipio">Município</span>
                    <asp:TextBox ID="TxtMunicipio" runat="server" CssClass="form-control" placeholder="Município" aria-label="Municipio" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="d-grid gap-2">
                    <asp:Button ID="BtnCadastrar" runat="server" CssClass="btn btn-success" Text="Confirmar" OnClick="BtnCadastrar_Click" />
                    <asp:Button ID="BtnEditar" runat="server" CssClass="btn btn-success" Text="Editar" OnClick="BtnEditar_Click" Visible="false" />
                </div>
            </div>
        </div>

        <asp:HiddenField ID="HdnIdCliente" runat="server" />

    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="LevsLogAppWebForms.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 class="text-center">Cadastre o Cliente</h3>
        <div class="row mt-4">
            <div class="col-md-3">
                <div class="col mb-3">
                    <asp:TextBox ID="TxtNome" runat="server" CssClass="form-control" placeholder="Primeiro Nome" aria-label="First name" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtSobrenome" runat="server" CssClass="form-control" placeholder="Sobrenome" aria-label="Last Name" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" placeholder="Email" aria-label="Email" />
                </div>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtDataNascimento" runat="server" CssClass="form-control" placeholder="Data de Nascimento" aria-label="Data de Nascimento"  />
                </div>
            </div>
            <div class="col-md-5">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtEndereco" runat="server" CssClass="form-control" placeholder="Endereço" aria-label="Endereco" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtNumero" runat="server" CssClass="form-control" placeholder="Numero" aria-label="Numero" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtCep" runat="server" CssClass="form-control" placeholder="Cep" aria-label="Cep" />
                </div>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtEstado" runat="server" CssClass="form-control" placeholder="Estado" aria-label="Estado" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtMunicipio" runat="server" CssClass="form-control" placeholder="Municipio" aria-label="Municipio" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="d-grid gap-2">
                    <asp:Button ID="BtnCadastrar" runat="server" CssClass="btn btn-success" Text="Confirmar" OnClick="BtnCadastrar_Click" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>

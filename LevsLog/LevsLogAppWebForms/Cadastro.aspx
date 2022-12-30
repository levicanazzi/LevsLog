<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="LevsLogAppWebForms.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 class="text-center">Cadastre o Cliente</h3>
        <div class="row mt-4">
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <span class="input-group-text">Nome</span>
                    <asp:TextBox ID="TxtNome" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="col-md-6">
                <div class="input-group mb-3">
                    <span class="input-group-text">Sobrenome</span>
                    <asp:TextBox ID="TxtSobrenome" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <span class="input-group-text">Nascimento</span>
                    <asp:TextBox ID="TxtDataNascimento" runat="server" CssClass="form-control" />
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="d-grid gap-2">
                    <asp:Button ID="BtnCadastrar" runat="server" CssClass="btn btn-success" Text="Confirmar" OnClick="BtnCadastrar_Click"/>
                </div>
            </div>
        </div>

    </div>
</asp:Content>

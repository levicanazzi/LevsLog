<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orcamento.aspx.cs" Inherits="LevsLogAppWebForms.Orcamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 class="text-center">Solicitar Orcamento</h3>
        <div class="row mt-4">
            <div class="col-md-2">
                <div class="col mb-3">
                    <asp:TextBox ID="TxtIdCliente" runat="server" CssClass="form-control" placeholder="Id do Cliente" aria-label="Id do Cliente" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtTipoServico" runat="server" CssClass="form-control" placeholder="Tipo de Serviço" aria-label="Tipo de Serviço" />
                </div>
            </div>
            <div class="col-md-5">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtEndereco" runat="server" CssClass="form-control" placeholder="Endereço" aria-label="Endereco" />
                </div>
            </div>
            <div class="col-md-1">
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
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtEstado" runat="server" CssClass="form-control" placeholder="Estado" aria-label="Estado" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtMunicipio" runat="server" CssClass="form-control" placeholder="Municipio" aria-label="Municipio" />
                </div>
            </div>
        </div>
        <h4>Produtos</h4>
        <div class="row mt-3">
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtAltura" runat="server" CssClass="form-control" placeholder="Altura" aria-label="Altura" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtLargura" runat="server" CssClass="form-control" placeholder="Largura" aria-label="Largura" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtComprimento" runat="server" CssClass="form-control" placeholder="Comprimento" aria-label="Comprimento" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <asp:TextBox ID="TxtPeso" runat="server" CssClass="form-control" placeholder="Peso" aria-label="Peso" />
                </div>
            </div>
            <div class="col-md-1">
                <div class="d-grid gap-2">
                    <asp:Button ID="BtnAdicionarProduto" runat="server" CssClass="btn btn-dark" Text="Adicionar" />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="d-grid gap-2">
                    <asp:Button ID="BtnCadastrar" runat="server" CssClass="btn btn-success" OnCLick="BtnCadastrar_Click" Text="Confirmar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

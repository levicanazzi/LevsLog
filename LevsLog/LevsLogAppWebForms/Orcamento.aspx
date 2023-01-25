<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orcamento.aspx.cs" Inherits="LevsLogAppWebForms.Orcamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 class="text-center">Solicitar Orcamento</h3>
        <div class="row mt-4">
            <div class="col-md-3">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtIdCliente">Id do Cliente</span>
                    <asp:TextBox ID="TxtIdCliente" runat="server" CssClass="form-control" placeholder="Id do Cliente" aria-label="Id do Cliente" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtTipoServico">Tipo de Serviço</span>
                    <asp:TextBox ID="TxtTipoServico" runat="server" CssClass="form-control" placeholder="Tipo de Serviço" aria-label="Tipo de Serviço" />
                </div>
            </div>
            <div class="col-md-5">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtEndereco">Endereço</span>
                    <asp:TextBox ID="TxtEndereco" runat="server" CssClass="form-control" placeholder="Endereço" aria-label="Endereco" />
                </div>
            </div>
        </div>
        <div class="row mt-4">
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
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtEstado">Estado</span>
                    <asp:TextBox ID="TxtEstado" runat="server" CssClass="form-control" placeholder="Estado" aria-label="Estado" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtMunicipio">Município</span>
                    <asp:TextBox ID="TxtMunicipio" runat="server" CssClass="form-control" placeholder="Municipio" aria-label="Municipio" />
                </div>
            </div>
        </div>
        <h4>Produtos</h4>
        <div class="row mt-3">
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtNomeProduto">Nome</span>
                    <asp:TextBox ID="TxtNomeProduto" runat="server" CssClass="form-control" placeholder="Nome" aria-label="Nome" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtAltura">Altura</span>
                    <asp:TextBox ID="TxtAltura" runat="server" CssClass="form-control" placeholder="Altura" aria-label="Altura" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtLargura">Largura</span>
                    <asp:TextBox ID="TxtLargura" runat="server" CssClass="form-control" placeholder="Largura" aria-label="Largura" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtComprimento">Comprimento</span>
                    <asp:TextBox ID="TxtComprimento" runat="server" CssClass="form-control" placeholder="Comprimento" aria-label="Comprimento" />
                </div>
            </div>
            <div class="col-md-2">
                <div class="input-group mb-3">
                    <span class="input-group-text" id="TxtPeso">Peso</span>
                    <asp:TextBox ID="TxtPeso" runat="server" CssClass="form-control" placeholder="Peso" aria-label="Peso" />
                </div>
            </div>
            <div class="col-md-1">
                <div class="d-grid gap-2">
                    <asp:Button ID="BtnAdicionarProduto" runat="server" CssClass="btn btn-dark" Text="Adicionar"  OnClick="BtnAdicionarProduto_Click"/>
                </div>
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-md-12">
                <asp:GridView ID="GvProdutos" runat="server" CssClass="table table-sm" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Nome" HeaderText="Nome Produto" />
                        <asp:BoundField DataField="Altura" HeaderText="Altura" />
                        <asp:BoundField DataField="Largura" HeaderText="Largura" />
                        <asp:BoundField DataField="Comprimento" HeaderText="Comprimento" />
                        <asp:BoundField DataField="Peso" HeaderText="Peso" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-12">
                <div class="d-grid gap-2">
                    <asp:Button ID="BtnCadastrar" runat="server" CssClass="btn btn-success" OnCLick="BtnCadastrar_Click" Text="Confirmar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

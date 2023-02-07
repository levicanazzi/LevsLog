<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" Async="true" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="LevsLogAppWebForms.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h3 class="text-center">Clientes</h3>



        <div class="row mt-3">
            <div class="col-md-12">
                <asp:GridView ID="GvClientes" runat="server" CssClass="table table-sm" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="false" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Sobrenome" HeaderText="Sobrenome" />
                        <asp:BoundField DataField="DataNascimento" HeaderText="Data de Nascimento" DataFormatString="{0:dd/MM/yyyy}" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:TemplateField HeaderText="Editar">
                            <ItemTemplate>
                                <asp:Button ID="BtnEditCliente" runat="server" CssClass="btn btn-success" OnCommand="BtnEditCliente_Command" CommandArgument='<%#Eval("Id")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Excluir">
                            <ItemTemplate>
                                <asp:Button ID="BtnExcluirCliente" runat="server" CssClass="btn btn-success" UseSubmitBehavior="false" OnCommand="BtnExcluirCliente_Command" CommandArgument='<%#Eval("Id")%>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>



        <div class="row">
            <div class="col-md-12">
                <div class="d-grid gap-2">
                    <a class="btn btn-success" href="Cadastro.aspx">Novo Cliente</a>
                </div>
            </div>
        </div>






    </div>


    <div class="modal fade" id="myModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    ...
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
        </div>
    </div>
    <button type="button" onclick="openModal()">teste</button>

    
</asp:Content>

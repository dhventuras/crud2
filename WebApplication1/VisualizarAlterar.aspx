<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarAlterar.aspx.cs" Inherits="WebApplication1.VisualizarAlterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Atualizar/Alterar Cadastro </title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <!-- Última versão CSS compilada e minificada -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

    <!-- Tema opcional -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous" />

    <!-- Última versão Java compilada e minificada -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

    <link href="css/estiloGeral.css" type="text/css" rel="stylesheet" />
</head>
<body class="cadastro">
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-3"></div>
                <div class="col-lg-6">
                    <!-- Modal content-->
                    <div class="modal-content  aocentro">
                        <div class="modal-header">
                            <h3 class="modal-title">Visualizar / Alterar</h3>
                        </div>
                        <div class="modal-body">
                            <div class="ltx1">
                                <asp:TextBox CssClass="form-control ltx1" ID="txtNome" runat="server" placeholder="Digite o nomo "></asp:TextBox>
                            </div>
                            <div class="ltx1">
                                <asp:TextBox CssClass="form-control ltxt1" ID="txtEndereco" runat="server" placeholder="Digite o Endereço"></asp:TextBox>
                            </div>
                            <div class="ltx1">
                                <asp:TextBox CssClass="form-control ltxt1" ID="txtBairro" runat="server" placeholder="Digite a Bairro"></asp:TextBox>
                            </div>
                            <div class="ltx1">
                                <asp:TextBox CssClass="form-control " ID="txtCep" runat="server" placeholder="Digite o Cep"></asp:TextBox>
                            </div>
                            <div class="ltx1">
                                <asp:TextBox CssClass="form-control ltxt1" ID="txtTelefone" runat="server" placeholder="Digite o Telefone"></asp:TextBox>
                            </div>
                            <div class="ltx1">
                                <asp:TextBox CssClass="form-control " ID="txtEmail" runat="server" placeholder="Digite o Email"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <div class="ltx1">
                                <br />
                                <div class="row btncentro">
                                    <div>
                                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                    </div>
                                    <br />
                                    <asp:Button CssClass="btn-primary" ID="Salvar" runat="server" Text="Salvar" OnClick="Salvar_Click" />
                                    <asp:Button CssClass="btn-danger" ID="Deletar" runat="server" Text="Deletar" OnClick="Deletar_Click" />
                                    <asp:Button CssClass="btn-info" ID="cliqueCancelar" runat="server" Text="Voltar" OnClick="cliqueCancelar_Click" />
                                </div>
                            </div>
                            <div>
                                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="col-sm-3"></div>

            </div>
        </div>
    </form>
</body>
</html>

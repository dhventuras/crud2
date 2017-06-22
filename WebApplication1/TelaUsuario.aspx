<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaUsuario.aspx.cs" Inherits="WebApplication1.TelaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tela Usuário</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <!-- Última versão CSS compilada e minificada -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

    <!-- Tema opcional -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous" />

    <!-- Última versão JavaScript compilada e minificada -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

    <link href="css/estiloGeral.css" type="text/css" rel="stylesheet" />

</head>
<body class="cadastro">
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-4 aocentro2">
                </div>
                <div class="col-lg-4 aocentro2">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h1>Área do Usuário</h1>
                        </div>
                        <div class="modal-body">
                            <div class="container-fluid">
                                <div class="row">
                                    <div class=" col-md-12">
                                        <asp:Button CssClass="btn btn-primary" ID="pg_cadastro" runat="server" Text="Cadastro" OnClick="pg_cadastro_Click" />
                                    </div>
                                    <div class=" col-md-12" style="margin-top: 10px">
                                        <asp:TextBox ID="txtPesquisa" runat="server" placeholder="Pesquisar por nome"></asp:TextBox>
                                        <asp:Button ID="Button2" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
                                    </div>
                                </div>
                            </div>                            
                        </div>
                        <div class="modal-footer">
                            <div>
                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                            </div>
                            <asp:Button CssClass="btn btn-danger" ID="btn_Sair" runat="server" Text="Sair" OnClick="btn_Sair_Click" />

                        </div>
                    </div>
                </div>
                <div class="col-lg-4 aocentro2">
                </div>
            </div>
    </form>
</body>
</html>

'<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title>Projeto Crud</title>

    <!-- Última versão CSS compilada e minificada -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

    <!-- Tema opcional -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous" />

    <!-- Última versão JavaScript compilada e minificada -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

    <link href="css/estiloGeral.css" type="text/css" rel="stylesheet" />
    <style>
        .cor-branca{
            color:white;
        }
    </style>

</head>
<body>
    <div class="container-fluid"></div>
    <form id="form1" runat="server">
        <div class="container-fluid of">
            <div class="row-fluid" style="te">
                <h1 class="centralizar cor-branca" >Crud</h1>
            </div>
            <div class="row-fluid">
                <div class="col-lg-4 ">
                </div>
                <div class="col-lg-4 ">
                    <!-- Modal content-->
                    <div class="modal-content col-lg-12 aocentro">
                        <div class="modal-header">
                            <h3 class="modal-title">Login</h3>
                        </div>
                        <div class="ltx1">
                            <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Usuario ou E-mail"></asp:TextBox>
                        </div>
                        <div class="ltx1">
                            <asp:TextBox CssClass="form-control" ID="txtSenha" runat="server" placeholder="Senha"></asp:TextBox>
                        </div>

                        <div class="modal-footer">
                            <div style="text-align: center; margin-top: 2px">
                                <div>
                                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                </div>
                                <div>
                                    <asp:Button runat="server" ID="btnEntrar" Text="Entrar" CssClass="btn" OnClick="btnEntrar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4"></div>
            </div>
        </div>
    </form>
</body>
</html>

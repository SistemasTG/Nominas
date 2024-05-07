<%@ Page Title="Consulta de Nominas" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VNominas.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="Css/styleLogin.css" />
    <link rel="stylesheet" type="text/css" href="Css/styleFont.css" />
    <link rel="stylesheet" type="text/css" href="Css/font-awesome.css" />
</head>
<body>
    <div class="container">
    <img src="./Imagenes/logoL.jpg" style="height: 147px; width: 146px"/>
    <form id="form1" runat="server" submitdisabledcontrols="True">
    <div class="form-input">
        <asp:TextBox ID="txtUser" runat="server" placeholder="Número de Empleado"  CssClass="txtUser" Font-Bold="False" Font-Italic="False" ForeColor="#666666" OnTextChanged="txtUser_TextChanged" MaxLength="5"></asp:TextBox>    
    </div>
        <div class="form-input">    
        <asp:TextBox ID="txtpass" placeholder="Contraseña" runat="server" TextMode="Password" ForeColor="#66666" CssClass="txtpass" OnTextChanged="txtpass_TextChanged"></asp:TextBox>
    </div>     
        <asp:Button ID="btnEntrar" runat="server" Text="Iniciar Sesión" CssClass="btnEntrar" Height ="30px" Width="223px" OnClick="btnEntrar_Click"/>
        <br />
        <br />
<%--        <asp:HyperLink ID="LinkRegistro" runat="server" NavigateUrl="Registro.aspx" Text="Registrarse" Visible=" false" DataNavigateUrlFormatString="Enviar Nomina.aspx?amount={0}&date={1}"> ></asp:HyperLink>--%>

    </form>
    </div>
</body>
</html>
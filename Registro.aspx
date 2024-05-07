<%@ Page Title="Registro" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Registro.aspx.cs" Inherits="VNominas.About" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >  
    <link rel="stylesheet" type="text/css" href="Css/styleRegistro.css" />
     <div class="container">
    
    <h1  style="color:white"" class="auto-style4">Registro de usuario</h1>
        <asp:RequiredFieldValidator  runat="server" ValidationGroup="Campos" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtCodigo" ></asp:RequiredFieldValidator>
        <asp:Label ID="Label1" runat="server" Text="Número de Empleado: " CssClass="label" Font-Names="Arial"></asp:Label>
     <asp:TextBox ID="txtCodigo" runat="server" MaxLength="5" MinLength="5" Placeholder="Número de Empleado" ValidationGroup="Campos" ></asp:TextBox>
       <br />
       
    <asp:Label ID="Label2" runat="server" Text="Nombre: " CssClass="label" Font-Names="Arial" Visible="true"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" CssClass="txtNombre" MaxLength="50"   Placeholder="Ingresa tu nombre" ValidationGroup="Campos" Enabled="false"  Visible="true"></asp:TextBox>
      <br />
    
    <asp:Label ID="Label4" runat="server" Text="Contraseña: " CssClass="label" Font-Names="Arial"></asp:Label>
    <asp:TextBox ID="txtContraseña" enabled="false" runat="server" CssClass="txtContraseña"  Placeholder=" Ingresa una Contraseña" MinLength="8" ></asp:TextBox>
        <br />
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btnRegistrar" OnClick="btnRegistrar_Click"  ValidationGroup="Campos"/> 
         <asp:Button ID="btnGenerar" runat="server" Text="Generar" CssClass="btnGenerar"   ValidationGroup="Campos" OnClick="btnGenerar_Click"/>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="*Ingrese Valores Numericos" ForeColor="Red" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator> 
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"  ControlToValidate="txtNombre" ErrorMessage="*Ingrese solo letras" ForeColor="Red"  ValidationExpression="^[A-Za-z ]*$"></asp:RegularExpressionValidator>             
    </div>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="head">
    <style type="text/css">
        
    </style>
</asp:Content>


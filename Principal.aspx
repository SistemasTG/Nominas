<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Principal.aspx.cs" Inherits="VNominas.Principal" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server" >
    <link rel="stylesheet" type="text/css" href="Css/StylePrincipal.css" />
    <link rel="stylesheet" type="text/css" href="Css/Principal.css" />
    <asp:Menu ID="Menu4" AutoPostBack="false" runat="server" Orientation="Horizontal"  Width="442px" MaximumDynamicDisplayLevels="0" Font-Bold="False" Font-Italic="False" Font-Names="Arial Narrow" Font-Strikeout="False" Font-Underline="False" ForeColor="#0066FF" Height="51px" RenderingMode="Table" OnMenuItemClick="Menu4_MenuItemClick" CssClass="auto-style9" style="margin-left: 400px" >
      <DynamicMenuItemStyle HorizontalPadding="0px" ItemSpacing="0px" VerticalPadding="0px" />
      <Items>
          <asp:MenuItem Text="VISUALIZAR NOMINAS" Value="1"></asp:MenuItem>         
          <asp:MenuItem Text="CAMBIAR CONTRASEÑA" Value="2" ></asp:MenuItem>
                   
                                                          
     </Items>
     <StaticMenuItemStyle ItemSpacing="100px" VerticalPadding="1px" Font-Bold="False" Font-Italic="False" Font-Names="Calibri" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="#666666" />
        <StaticMenuStyle HorizontalPadding="1px" VerticalPadding="1px" />
          <StaticSelectedStyle ForeColor="white" BorderStyle="None" HorizontalPadding="1px" ItemSpacing="1px" BackColor="#04C0FF" />
     </asp:Menu>
    <br />
    <asp:Menu ID="Menu3" AutoPostBack="false" runat="server" Orientation="Horizontal"  Width="861px" MaximumDynamicDisplayLevels="0" Font-Bold="False" Font-Italic="False" Font-Names="Arial Narrow" Font-Strikeout="False" Font-Underline="False" ForeColor="#0066FF" Height="51px" RenderingMode="Table" OnMenuItemClick="Menu3_MenuItemClick" CssClass="auto-style9" style="margin-left: 320px" >
      <DynamicMenuItemStyle HorizontalPadding="0px" ItemSpacing="0px" VerticalPadding="0px" />
      <Items>
          <asp:MenuItem Text="VISUALIZAR NOMINAS" Value="1"></asp:MenuItem>         
          <asp:MenuItem Text="CAMBIAR CONTRASEÑAS" Value="2" ></asp:MenuItem>
            <asp:MenuItem Text="REGISTRAR USUARIO"  Value="3"></asp:MenuItem> 
          <asp:MenuItem Text="CAMBIAR CONTRASEÑA"  Value="4"></asp:MenuItem>
                                                          
     </Items>
     <StaticMenuItemStyle ItemSpacing="100px" VerticalPadding="1px" Font-Bold="False" Font-Italic="False" Font-Names="Calibri" Font-Overline="False" Font-Size="Medium" Font-Underline="False" ForeColor="#666666" />
        <StaticMenuStyle HorizontalPadding="1px" VerticalPadding="1px" />
          <StaticSelectedStyle ForeColor="white" BorderStyle="None" HorizontalPadding="1px" ItemSpacing="1px" BackColor="#04C0FF" />
     </asp:Menu>
    <asp:MultiView  ID="MultiviewP" runat="server" ActiveViewIndex="0">
   <asp:View runat="server" ID="PanelInicio">

       <link rel="stylesheet" href="Css/Principal.css" type="text/css" media="screen" />
    <script src="scripts/jquery-1.5.2.min.js" type="text/javascript"></script>
    <script src="scripts/jcarousellite_1.0.1c5.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#slidebox").jCarouselLite({
                vertical: false,
                hoverPause: true,
                btnPrev: ".previous",
                btnNext: ".next",
                visible: 1,
                start: 0,
                scroll: 1,
                circular: true,
                auto: 5000,
                speed: 600,
                btnGo:
                    [".1", ".2",
                    ".3", ".4",
                    ".5", ".6"],
                afterEnd: function (a, to, btnGo) {
                    if (btnGo.length <= to) {
                        to = 0;
                    }
                    $(".thumbActive").removeClass("thumbActive");
                    $(btnGo[to]).addClass("thumbActive");
                }
            });
        });
    </script>
    <div class="div1">
        <div id="slidebox" aria-autocomplete="both">
            <div class="next"></div>
            <div class="previous"></div>
            <div class="thumbs">
                <a href="#" onclick="" class="1 thumbActive">1</a>
                <a href="#" onclick="" class="2">2</a>
                <a href="#" onclick="" class="3">3</a>
                <a href="#" onclick="" class="4">4</a>
                <a href="#" onclick="" class="5">5</a>
                <a href="#" onclick="" class="6">6</a>
            </div>
            <ul>
                <li class="imagen">
                    <img class="imagen" src="Imagenes/rh1.jpg" width="100%" height="100%" />
                    <h2>Nuestra Empresa</h2>
                    <h3>Tecnoglobal es una empresa mexicana especializada en la fabricación de productos del cuidado personal y del hogar, comprometida con el medio ambiente y la sociedad.</h3>
                </li>
                <li>
                    <img src="Imagenes/rh2.jpg" width="100%" height="100%" />
                    <h2>Visión</h2>
                    <h3>Ser una empresa líder en México en la fabricación de productos de cuidado personal y del hogar con alta rentabilidad, buscando la satisfacción total de nuestros clientes mediante la innovación constante en nuestros productos y procesos, el desarrollo integral y permanente de nuestros empleados, proveedores y aliados, siempre en armonía con el medio ambiente.</h3>
                </li>
                <li>
                    <img src="Imagenes/rh3.jpg" width="100%" height="100%" />
                    <h2>Misión</h2>
                    <h3>Desarrollar y producir artículos para el cuidado personal y del hogar, con excelente imagen, calidad y precio, preocupándonos por la distribución oportuna, por el desarrollo de nuevos productos y por mejorar los existentes basados en las necesidades de nuestros clientes, buscando el desarrollo profesional y personal de nuestra gente con un alto compromiso con el medio ambiente.</h3>
                </li>
                <li>
                    <img src="Imagenes/rh4.jpg" width="100%" height="100%" />
                    <h2>Valores</h2>
                    <h3>Respeto, entusiasmo, lealtad, honestidad, compromiso y trabajo en equipo.</h3>
                </li>
                <li>
                    <img src="Imagenes/rh5.jpg" width="100%" height="100%" />
                    <h2>Filosofia</h2>
                    <h3>Somos una empresa con fe en Dios, trabajamos con responsabilidad, disciplina y carácter.</h3>
                </li>
                <li>
                    <img src="Imagenes/rh6.jpg" width="100%" height="100%" />
                    <h2>Politica De Calidad e Inocuidad</h2>
                    <h3>En TECNOGLOBAL asumimos la responsabilidad y compromiso con el cliente de ofrecerle un producto adecuado a sus necesidades y conforme a los requisitos legales y reglamentarios de inocuidad, para garantizarle en todo momento su satisfacion.</h3>
                </li>
               
            </ul>
        </div> 
                <p>TECNOGLOBAL</p>
    </div>
   </asp:View>
        
        
        
        <asp:View runat="server" ID="View1">
   
    <br />
                                   
                                   
    
    <asp:Label ID="lblNombreE" runat="server" Text="Nombre : " CssClass="lblNombre"></asp:Label>
    <asp:Label ID="lblNE" runat="server" Text="......" CssClass="lblNombreE" ></asp:Label>
    <asp:Label ID="lblNombre" runat="server" Text="Codigo de Empleado : " CssClass="lblNombre"></asp:Label>
    <asp:Label ID="lblN" runat="server" Text="......" CssClass="lblN"></asp:Label>
   
    <asp:Label ID="lblAño" runat="server" Text="Año: " CssClass="lblAño"></asp:Label>
 
    <asp:DropDownList  ID="DropAño" runat="server" CssClass="DropSemana" OnSelectedIndexChanged="DropAño_SelectedIndexChanged">
     <asp:ListItem>Seleccione</asp:ListItem>
     <asp:ListItem>2023</asp:ListItem>
       <asp:ListItem>2024</asp:ListItem>   
    </asp:DropDownList>
    <asp:Label ID="lblsemana" font="Bold" runat="server" Text="Semana: " CssClass="lblSemana"></asp:Label>
    <asp:DropDownList ID="DropSemana" runat="server" CssClass="DropSemana">
        <asp:ListItem>Seleccione</asp:ListItem>
            

    </asp:DropDownList>
    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btnConsultar" OnClick="btnConsultar_Click1" />
    <br />
    <br />  
       <div style="height: 236px; width: 828px; overflow: scroll; margin-left: 220px">
       
       <asp:Datagrid ID="GridView2" DataKeyField="Ver" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC"  BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial" Font-Size="Small" ForeColor="#041B60" Height="226px" PageSize="5" Width="819px" OnitemCommand="GridView2_ItemCommand" CssClass="auto-style6" Multiselect="true" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateSelectButton="true" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" OnDataBinding="GridView2_DataBinding" AllowPaging="False" AllowCustomPaging="True" >
         <Columns>
            <asp:BoundColumn DataField="Nomina" HeaderText="Nomina"></asp:BoundColumn>
           <asp:BoundColumn DataField="Ver" HeaderText="Nomina" Visible="false"></asp:BoundColumn>
           <asp:ButtonColumn ButtonType="PushButton" CommandName="Ver" HeaderText="Ver" Text="Ver"></asp:ButtonColumn>
           <asp:ButtonColumn ButtonType="PushButton" CommandName="Descargar" HeaderText="Descargar" Text="Descargar"></asp:ButtonColumn>
           <asp:ButtonColumn ButtonType="PushButton" CommandName="Enviar" HeaderText="Enviar" Text="Enviar"></asp:ButtonColumn>
            <%--<asp:TemplateColumn HeaderText="Ver">
                <ItemTemplate><asp:HyperLink runat="server" Text='<%#Eval("Ver") %>'  NavigateUrl='<%#"Enviar.aspx?Ver=" + HttpUtility.UrlEncode(Eval("Ver").ToString())%>'  DataTextField="Nomina" Target="_blank">
                   </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn>--%>
          </Columns>
         <FooterStyle BackColor="#041b60" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#041b60" Font-Bold="True" ForeColor="White" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
          <ItemStyle ForeColor="#000066" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
              <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
              </asp:Datagrid>
          </div>
       </asp:View>
        <asp:View runat="server" ID="View5">
             <br />
         <br />
         <asp:Label ID="Label7" runat="server" Text="Codigo de Empleado : " CssClass="lblNombre"></asp:Label>
         <asp:Label ID="lblNombE" runat="server" Text="......" CssClass="lblN"></asp:Label>
         <asp:Label ID="Label9" runat="server" Text="Codigo de Empleado : " CssClass="lblNombre"></asp:Label>
         <asp:Label ID="lblCodE" runat="server" Text="......" CssClass="lblN"></asp:Label>
         <br />
         <br />

            <br />
            <br />
            <br />
           


            <asp:Label runat="server" Text="Contraseña nueva : " CssClass="lblNombre"></asp:Label>
            <asp:TextBox runat="server" ID="txtContra"  CssClass="txtCC" TextMode="Password" ></asp:TextBox>

             <asp:Button ID="Button1" runat="server" Text="Cambiar contaseña." OnClick="Button1_Click" CssClass="btnConsultar" />

        </asp:View>
     <asp:View  ID="EnviarNomina" runat="server">
         <br />
         <br />
         <asp:Label ID="Label2" runat="server" Text="Codigo de Empleado : " CssClass="lblNombre"></asp:Label>
         <asp:Label ID="lblNomE" runat="server" Text="......" CssClass="lblN"></asp:Label>
         <asp:Label ID="Label1" runat="server" Text="Codigo de Empleado : " CssClass="lblNombre"></asp:Label>
         <asp:Label ID="lblCodigo" runat="server" Text="......" CssClass="lblN"></asp:Label>
         <br />
         <br />
         <br />
         <br />
         
        
       <asp:Label runat="server" Text="Nomina : "  Font-Italic="True" Font-Bold="True" CssClass="lbl"></asp:Label>   
        <asp:Label runat="server" Text="..."  Font-Italic="True" Font-Bold="True" ID="lblDoc" Font-color="#041b60" ForeColor="#041B60"></asp:Label> 
         <asp:TextBox runat="server" ID="txtArch" CssClass="txtEnviar" Visible="false" ></asp:TextBox>
         <br /><br /><br />
    <asp:Label ID="lblDes" runat="server" Text="Correo Electronico: " Font-Bold="True" CssClass="lbl"></asp:Label>
    <asp:TextBox ID="txtDestino" runat="server" AutoCompleteType="Email" placeholder="Ingresa el Correo" CssClass="txtEnviar" Enabled="true"></asp:TextBox>
         <br/>
         <br />
         <asp:Label runat="server" Text="*Nota: Al enviar la nomina checar las carpetas spam o correo no deseado" Font-Bold="true" margin-left="76px"></asp:Label>
         <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click"  CssClass="btnEnviar"/>


</asp:View>
        
     <asp:View  ID="Consultar_Contraseñas" runat="server">
         <br />
         <br />
         <asp:Label ID="LblConsultar" runat="server" Text="Empleado : " CssClass="lblNombre"></asp:Label>
          <asp:Label ID="lblConsultarN" runat="server" Text="......" CssClass="lblN"></asp:Label>
         <asp:Label ID="lblConsC" runat="server" Text="Codigo : " CssClass="lblNombre"></asp:Label>
         <asp:Label ID="lblConsultarC" runat="server" Text="......" CssClass="lblN"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:textbox runat="server" ID="txtbuscar" placeholder="Número de Empleado" CssClass="txtbuscar" MaxLength="5" MinLength="5"></asp:textbox>
         <asp:Button  runat="server" ID="btnbuscar" Text="Buscar" OnClick="btnbuscar_Click"  CssClass="btnConsultar"/>
         <br />
         <br />
         <div class="auto-style7" >
         <asp:DataGrid runat="server" ID="GridContra"  CssClass="auto-style8" Width="603px" OnItemCommand="GridContra_ItemCommand" OnSelectedIndexChanged="GridContra_SelectedIndexChanged">
       <Columns>                      
           <asp:ButtonColumn HeaderText="Actualizar Contraseña" ButtonType="PushButton" Text="Actualizar Contraseña" CommandName="Actualizar" ></asp:ButtonColumn>
   </Columns>
             <FooterStyle BackColor="#041b60" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#041b60" Font-Bold="True" ForeColor="White" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
          <ItemStyle ForeColor="#000066" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" HorizontalAlign="Center" VerticalAlign="Middle" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
              <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
       </asp:DataGrid>
        </div>
 


</asp:View>
        <asp:View  ID="Registrar" runat="server">
            <link rel="stylesheet" type="text/css" href="Css/styleRegistro.css" />
     <div class="container">
    
    <h1  style="color:white"" class="auto-style4">Registro de usuario</h1>
        <asp:RequiredFieldValidator  runat="server" ValidationGroup="Campos" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtCodigo" ></asp:RequiredFieldValidator>
        <asp:Label ID="Label3" runat="server" Text="Número de Empleado: " CssClass="label" Font-Names="Arial" ></asp:Label>
     <asp:TextBox ID="txtCodigo" runat="server" MaxLength="5" MinLength="5" Placeholder="Número de Empleado" ValidationGroup="Campos" OnTextChanged="txtCodigo_TextChanged" ></asp:TextBox>
       <br />
       
    <asp:Label ID="Label4" runat="server" Text="Nombre: " CssClass="label" Font-Names="Arial" Visible="true"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" CssClass="txtNombre" MaxLength="50"   Placeholder="Ingresa tu nombre" ValidationGroup="Campos" Enabled="false"  Visible="true"></asp:TextBox>
      <br />
    
    <asp:Label ID="Label5" runat="server" Text="Contraseña: " CssClass="label" Font-Names="Arial"></asp:Label>
    <asp:TextBox ID="txtContraseña" enabled="false" runat="server" CssClass="txtContraseña"  Placeholder=" Ingresa una Contraseña" MinLength="8" ></asp:TextBox>
        <br />
         <asp:Label ID="Label6" runat="server" Text="Tipo de usuario : " CssClass="lbluser" Font-Names="Arial"></asp:Label>
         <asp:DropDownList runat="server" ID="DropUser" CssClass="dropuser">
             <asp:ListItem>Seleccione</asp:ListItem>
             <asp:ListItem>Usuario</asp:ListItem>
             <asp:ListItem>Administrador</asp:ListItem>
         </asp:DropDownList>
         <br />
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btnRegistrar" OnClick="btnRegistrar_Click"  ValidationGroup="Campos"/> 
         <asp:Button ID="btnGenerar" runat="server" Text="Generar contraseña" CssClass="btnGenerar"   ValidationGroup="Campos" OnClick="btnGenerar_Click" Visible="false"/>
        <br />
         <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCodigo" ErrorMessage="*Ingrese Valores Numericos" ForeColor="Red" ValidationExpression="^[0-9]*"></asp:RegularExpressionValidator> 
    </div>
</asp:View>
        </asp:MultiView>
</asp:Content>



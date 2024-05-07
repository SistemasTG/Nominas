using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Data;
using System.Windows.Forms;
namespace VNominas
{
    public partial class Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
              
            
            }

        }


        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string Empleado = txtUser.Text;
            string Contraseña = txtpass.Text;
          
            int  usuario = Login.IniciarSesion(Empleado,Contraseña);
                      
            if (usuario == 0)
            {
                Response.Write("<script>alert (" + "'Usuario ó Contraseña Incorrectos'" + ") </script>");
            }
            else if (usuario != 0)
            {
                Session["Empleado"] = Empleado;
                Page.Response.Redirect("Principal.aspx");
            }
        }

        protected void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if(txtCodigo.AutoPostBack == true)
            {
                VerificaEmpleado(txtCodigo.Text);
            }
            else
            {

            }
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (var context = new RECIBOSEntities2())
            {
                using (var filtro = new TG23Entities())
                {
                    var usuarios = context.Set<Usuarios>();
                    var check = filtro.Set<Empprin>();
                    bool existe = context.Usuarios.Any(x => x.Empleado == txtCodigo.Text);
                    bool comprobar = filtro.Empprin.Any(x => x.CLAVE == txtCodigo.Text);
                    if (comprobar == true) { 

                         if (existe == true)
                         {
                        Response.Write("<script>alert (" + "'El usuario ya existe'" + ") </script>");

                         }
                    else
                    {
                        VerificaEmpleado(txtCodigo.Text);
                        //string passw = Encriptacion.GetSHA256(txtContraseña.Text);
                        //usuarios.Add(new Usuarios { Empleado = txtCodigo.Text, Nombre = txtNombre.Text, Contraseña = Encriptacion.GetSHA256(txtContraseña.Text) });
                        //Session["Correo"] = txtCE;
                        context.SaveChanges();
                            Response.Write("<script>alert (" + "'Usuario Registrado'" + ") </script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert (" + "'El numero de empleado no existe'" + ") </script>");
                    }
                }

            }
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("Default.aspx");
        }

        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void VerificaEmpleado(string NumeroE)
        {
            using (TG23Entities context = new TG23Entities())
            {
                 var Vusuario = context.Empprin.Where(e => e.CLAVE == NumeroE).ToList();
                foreach (Empprin emp in Vusuario)
                {  
                    txtNombre.Text = emp.NOMBREN.Trim()+" "+ emp.NOMBREP.Trim()+ " " + emp.NOMBREM.Trim();
                }
            }
        }

        public void GenerarContraseña()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 8;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
           
            txtContraseña.Text = contraseniaAleatoria.ToString();
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            VerificaEmpleado(txtCodigo.Text);
            GenerarContraseña();
        }
    }
}
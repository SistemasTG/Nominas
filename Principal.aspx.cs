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
using System.Data.SqlClient;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using SimpleImpersonation;

namespace VNominas
{
    public partial class Principal : System.Web.UI.Page
    {
        string año = DateTime.Now.Year.ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) {

                Loading();
            }
        }

        public void Loading()
        {
            var datos = "WET-LINE|EDEJHERNANDEZ|TGeh3000+1219958";
            var credencialesdatos = datos.Split('|'); 
            var Credenciales = new UserCredentials(credencialesdatos[0] ,  credencialesdatos[1], credencialesdatos[2]);

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            Impersonation.RunAsUser(Credenciales, SimpleImpersonation.LogonType.NewCredentials, () =>
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            {

                 if (DropAño.Text == "2024" || DropAño.Text == "Seleccione")
                 {

                     using (var db = new RECIBOSEntities2())
                     {

                         string empleado = Session["Empleado"].ToString();
                         var users = db.Set<Usuarios>();
                         bool exist = db.Usuarios.Any(x => x.Empleado == empleado && x.Tipo_usuario == "A");

                         if (exist == true)
                         {
                             Menu3.Visible = true;
                             Menu4.Visible = false;
                             MultiviewP.ActiveViewIndex = 0;
                             VerificarSession();
                             lblN.Text = Session["Empleado"].ToString();
                             BNombre(Session["Empleado"].ToString());
                             var path = "//swl001/Giro32/" + año + " cfdi";
                             var dir = new DirectoryInfo(path);
                             var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                             List<Archivos> lista = new List<Archivos>();

                             foreach (var file in files)
                             {
                                 string[] Nombre = file.Name.Split('_');
                                 string NE = Nombre[1];
                                 string semana = Nombre[3];
                                 string NSemana = Nombre[4];

                                 if (lblN.Text == NE)
                                 {
                                     lista.Add(new Archivos()
                                     {
                                         Nomina = file.Name.ToString(),
                                         Ver = file.FullName.ToString()

                                     });
                                     lista.OrderByDescending(x => x.Nomina);
                                     DropSemana.Items.Add(semana + " " + NSemana);
                                 }

                             }
                             GridView2.DataSource = lista;
                             GridView2.DataBind();
                         }
                         else
                         {
                             MultiviewP.ActiveViewIndex = 1;
                             Menu3.Visible = false;
                             Menu4.Visible = true;


                             VerificarSession();
                             lblN.Text = Session["Empleado"].ToString();
                             BNombre(Session["Empleado"].ToString());

                             var path = "//swl001/Giro32/" + año + " cfdi";
                             var dir = new DirectoryInfo(path);
                             var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                             List<Archivos> lista = new List<Archivos>();

                             foreach (var file in files)
                             {
                                 string[] Nombre = file.Name.Split('_');
                                 string NE = Nombre[1];
                                 string semana = Nombre[3];
                                 string NSemana = Nombre[4];
                                 if (lblN.Text == NE)
                                 {
                                     lista.Add(new Archivos()
                                     {
                                         Nomina = file.Name.ToString(),
                                         Ver = file.FullName.ToString()

                                     });
                                     DropSemana.Items.Add(semana + " " + NSemana);
                                 }
                             }

                             GridView2.DataSource = lista;
                             GridView2.DataBind();
                         }

                     }

                 }
                 else if (DropAño.Text == "2023")
                 {
                     using (var db = new RECIBOSEntities2())
                     {

                         string empleado = Session["Empleado"].ToString();
                         var users = db.Set<Usuarios>();
                         bool exist = db.Usuarios.Any(x => x.Empleado == empleado && x.Tipo_usuario == "A");

                         if (exist == true)
                         {
                             Menu3.Visible = true;
                             Menu4.Visible = false;
                             MultiviewP.ActiveViewIndex = 0;
                             VerificarSession();
                             lblN.Text = Session["Empleado"].ToString();
                             BNombre(Session["Empleado"].ToString());
                             var path = "//swl001/2023 cfdi";
                             var dir = new DirectoryInfo(path);
                             var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                             List<Archivos> lista = new List<Archivos>();

                             foreach (var file in files)
                             {
                                 string[] Nombre = file.Name.Split('_');
                                 string NE = Nombre[1];
                                 string semana = Nombre[3];
                                 string NSemana = Nombre[4];

                                 if (lblN.Text == NE)
                                 {
                                     lista.Add(new Archivos()
                                     {
                                         Nomina = file.Name.ToString(),
                                         Ver = file.FullName.ToString()

                                     });
                                     lista.OrderByDescending(x => x.Nomina);
                                     DropSemana.Items.Add(semana + " " + NSemana);
                                 }

                             }
                             GridView2.DataSource = lista;
                             GridView2.DataBind();
                         }
                         else
                         {
                             MultiviewP.ActiveViewIndex = 1;
                             Menu3.Visible = false;
                             Menu4.Visible = true;


                             VerificarSession();
                             lblN.Text = Session["Empleado"].ToString();
                             BNombre(Session["Empleado"].ToString());

                             var path = "//swl001/2023 cfdi";
                             var dir = new DirectoryInfo(path);
                             var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                             List<Archivos> lista = new List<Archivos>();

                             foreach (var file in files)
                             {
                                 string[] Nombre = file.Name.Split('_');
                                 string NE = Nombre[1];
                                 string semana = Nombre[3];
                                 string NSemana = Nombre[4];
                                 if (lblN.Text == NE)
                                 {
                                     lista.Add(new Archivos()
                                     {
                                         Nomina = file.Name.ToString(),
                                         Ver = file.FullName.ToString()

                                     });
                                     DropSemana.Items.Add(semana + " " + NSemana);
                                 }
                             }

                             GridView2.DataSource = lista;
                             GridView2.DataBind();
                         }

                     }


                 }

             });
        }



            private void VerificarSession()
        {
            if (Session["Empleado"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }


        protected void btnConsultar_Click1(object sender, EventArgs e)
        {
            var datos = "WET-LINE|EDEJHERNANDEZ|TGeh3000+1219958";
            var credencialesdatos = datos.Split('|');
            var Credenciales = new UserCredentials(credencialesdatos[0], credencialesdatos[1], credencialesdatos[2]);

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            Impersonation.RunAsUser(Credenciales, SimpleImpersonation.LogonType.NewCredentials, () =>
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            {
                if (DropAño.SelectedValue == "Seleccione" && DropSemana.SelectedValue == "Seleccione")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();
                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];
                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }
                    GridView2.DataSource = lista;
                    GridView2.DataBind();

                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 1")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 1";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()
                            });

                        }
                    }
                    GridView2.DataSource = lista;
                    GridView2.DataBind();

                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 2")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 2";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 3")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 3";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 4")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 4";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();

                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 5")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 5";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }
                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 6")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 6";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }
                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 7")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 7";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 8")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 8";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 9")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM 9";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 10")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM10";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 11")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM11";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 12")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM12";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 13")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM13";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 14")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM14";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 15")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM15";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 16")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM16";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 17")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM17";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 18")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM18";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 19")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM19";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 20")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM20";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];

                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 21")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM21";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 22")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM22";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 23")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM23";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 24")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM24";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 25")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM25";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 26")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM26";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 27")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM27";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 28")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM28";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 29")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM29";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 30")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM30";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 31")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM31";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 32")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM32";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 33")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM33";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 34")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM34";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 35")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM35";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 36")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM36";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 37")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM37";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 38")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM38";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 39")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM39";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 40")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM40";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 41")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM41";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 42")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM42";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 43")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM43";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 44")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM44";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 45")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM45";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 46")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM46";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 47")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM47";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 48")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM48";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 49")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM49";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 50")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM50";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 51")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM51";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }

                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == año && DropSemana.SelectedValue == "SEM 52")
                {
                    var path = "//swl001/Giro32/" + año + " cfdi/SEM52";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }
                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == "2023")
                {
                    DropSemana.Enabled = false;
                    var path = "//swl001/2023 cfdi";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }
                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
                else if (DropAño.SelectedValue == "2024")
                {
                    DropSemana.Enabled = true;
                    var path = "//swl001/Giro32/" + año + " cfdi";
                    var dir = new DirectoryInfo(path);
                    var files = dir.GetFiles("*.PDF", SearchOption.AllDirectories);
                    List<Archivos> lista = new List<Archivos>();

                    foreach (var file in files)
                    {
                        string[] Nombre = file.Name.Split('_');
                        string NE = Nombre[1];


                        if (lblN.Text == NE)
                        {
                            lista.Add(new Archivos()
                            {
                                Nomina = file.Name.ToString(),
                                Ver = file.FullName.ToString()

                            });

                        }
                    }
                    GridView2.DataSource = lista;
                    GridView2.DataBind();
                }
            });
        }

        protected void GridView2_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            var datos = "WET-LINE|EDEJHERNANDEZ|TGeh3000+1219958";
            var credencialesdatos = datos.Split('|');
            var Credenciales = new UserCredentials(credencialesdatos[0], credencialesdatos[1], credencialesdatos[2]);

            switch (e.CommandName)
            {
             case "Enviar":
                  
                        lblCodigo.Text = Session["Empleado"].ToString();
                        BCorreo(Session["Empleado"].ToString());
                        BNombre(lblCodigo.Text);
                        lblDoc.Text = e.Item.Cells[0].Text;
                        txtArch.Text = Server.MapPath(e.Item.Cells[1].Text);
                        MultiviewP.ActiveViewIndex = 3;
                                      
                    break;
                case "Descargar":
                
                    string FilePath = Server.MapPath(e.Item.Cells[1].Text);

                WebClient usuario = new WebClient();
                Byte[] Archivo = usuario.DownloadData(FilePath);
                if (Archivo != null)
                {
                    Response.ContentType = "application/pdf";

                    Response.AddHeader("content-disposition", Archivo.Length.ToString());
                    Response.BinaryWrite(Archivo);
                }
                  
                    break;

                case "Ver":
                    
                         string Path = Server.MapPath(e.Item.Cells[1].Text);
                         WebClient user = new WebClient();
                         Byte[] Arch = user.DownloadData(Path);

                         if (Arch != null)
                         {
                             Response.ContentType = "application/pdf";
                             this.Context.Response.AddHeader("Content-disposition", "inline; filename= Nomina.pdf");
                             Response.BinaryWrite(Arch);
                         }
                     
                break;         
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {  
            string ruta =txtArch.Text; 
            EnviarCorreos(txtDestino.Text, ruta);
            Response.Write("<script>alert (" + "'Nomina Enviada'" + ") </script>");
            MultiviewP.ActiveViewIndex = 1;       
        }
        public void EnviarCorreos(string Cdestino, string ruta)
        {
            string Corigen = "recibos_nomina@tecnoglobal.mx";
            string Contraseña = "TGrn45638*";
            string Asunto = "Solicitud de Nomina";
            MailMessage msj = new MailMessage(Corigen, Cdestino,Asunto, "");
            msj.Attachments.Add(new System.Net.Mail.Attachment(ruta));
            msj.IsBodyHtml = true;
            SmtpClient Mensaje = new SmtpClient("smtp-mail.outlook.com", 587);
            Mensaje.EnableSsl = true;
            Mensaje.UseDefaultCredentials = false;
            //Mensaje.Port = 587;
            Mensaje.Credentials = new NetworkCredential(Corigen, Contraseña);
            Mensaje.Send(msj);
            Mensaje.Dispose();
        }
        public void BCorreo(string Empleado)
        {
            using(RECIBOSEntities2 db = new RECIBOSEntities2())
            {
                var correo = db.Usuarios.Where(n => n.Empleado == Empleado).ToList();
                foreach(Usuarios us in correo)
                {
                    txtDestino.Text = us.Correo;                 
                }
            }
        }
        public void BNombre(string Empleado)
        {
            using (RECIBOSEntities2 db = new RECIBOSEntities2())
            {
                var correo = db.Usuarios.Where(n => n.Empleado == Empleado).ToList();
                foreach (Usuarios us in correo)
                {
                    lblNE.Text = us.Nombre;
                    lblConsultarN.Text = us.Nombre;
                    lblNomE.Text = us.Nombre;
                    lblNombE.Text = us.Nombre;


                }
            }
        }
       

        public void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {         

        }
        protected void DropAño_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void GridView2_DataBinding(object sender, EventArgs e)
        {

        }
        protected void Menu4_MenuItemClick(object sender, MenuEventArgs e)
        {
            System.Web.UI.WebControls.MenuItem item = e.Item;
            if(item.Value == "1")
            {
                MultiviewP.ActiveViewIndex = 1;

            }else if(item.Value == "2")
            {
                lblCodE.Text = Session["Empleado"].ToString();
                MultiviewP.ActiveViewIndex = 2;
            }
        
        
        }
            protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {
            System.Web.UI.WebControls.MenuItem item = e.Item;

            if (item.Value == "1")
            {
                MultiviewP.ActiveViewIndex = 1;
                
            }
            else if (item.Value == "2")
            {
                lblConsultarC.Text = Session["Empleado"].ToString();
                using (RECIBOSEntities2 conex = new RECIBOSEntities2())
                {
                    //List<sp_Consulta_Contraseñas_Result> list = new List<sp_Consulta_Contraseñas_Result>();
                    var empleados = conex.Usuarios.Select(x => new { x.Empleado, x.Nombre }).ToList();
                    GridContra.DataSource =empleados;
                    GridContra.DataBind();
                }
             MultiviewP.ActiveViewIndex = 4;                  
            }else if(item.Value == "3")
            {
               
                MultiviewP.ActiveViewIndex = 5;
            }else if(item.Value == "4")
            {
                lblCodE.Text= Session["Empleado"].ToString();
                MultiviewP.ActiveViewIndex = 2;
            }
        }
      
        
        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            int empleado = Buscar.BuscarEmp(txtbuscar.Text);
           if(txtbuscar.Text == "")
            {
                using (RECIBOSEntities2 conex = new RECIBOSEntities2())
                {
                    GridContra.DataSource = conex.Usuarios.Select(x => new { x.Empleado, x.Nombre}).ToList();
                    GridContra.DataBind();
                }
            }         
            else
            {
                using (RECIBOSEntities2 conex = new RECIBOSEntities2())
                {
                    GridContra.DataSource = conex.Usuarios.Select(x => new { x.Empleado, x.Nombre }).Where(x => x.Empleado == txtbuscar.Text).ToList();
                    GridContra.DataBind();
                }

            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (var context = new RECIBOSEntities2())
            {
                
                using (var filtro = new TG24Entities())
                {
                    var usuarios = context.Set<Usuarios>();
                    var check = filtro.Set<Empprin>();
                    bool existe = context.Usuarios.Any(x => x.Empleado == txtCodigo.Text);
                    bool comprobar = filtro.Empprin.Any(x => x.CLAVE == txtCodigo.Text);
                     
                    if (comprobar == true)
                    {
                        if (existe == true)
                        {
                            Response.Write("<script>alert (" + "'El usuario ya existe'" + ") </script>");
                            txtCodigo.Text = "";
                            txtNombre.Text = "";
                            txtContraseña.Text = "";
                        }
                        else
                        {
                            if (DropUser.SelectedValue == "Usuario") { 
                            VerificaEmpleado(txtCodigo.Text);
                            //usuarios.Add(new Usuarios { Empleado = txtCodigo.Text, Nombre = txtNombre.Text, Contraseña = txtContraseña.Text, Tipo_usuario = "U", Contraseña_E= context.RegistrarUsuario(txtContraseña.Text) });
                            context.RegistrarUsuario(txtCodigo.Text, txtNombre.Text ,"U" ,txtContraseña.Text);
                            //Session["Correo"] = txtCE;
                            context.SaveChanges();
                            Response.Write("<script>alert (" + "'Usuario Registrado'" + ") </script>");
                            txtCodigo.Text = "";
                            txtNombre.Text = "";
                            txtContraseña.Text = "";
                            DropUser.Text = "Seleccione";
                            }
                            else if(DropUser.SelectedValue == "Administrador")
                            {
                                VerificaEmpleado(txtCodigo.Text);
                                //string passw = Encriptacion.GetSHA256(txtContraseña.Text);
                                //usuarios.Add(new Usuarios { Empleado = txtCodigo.Text, Nombre = txtNombre.Text, Contraseña = txtContraseña.Text, Tipo_usuario = "A" });
                                context.RegistrarUsuario(txtCodigo.Text, txtNombre.Text, "A", txtContraseña.Text);
                                //Session["Correo"] = txtCE;
                                context.SaveChanges();
                                Response.Write("<script>alert (" + "'Usuario Registrado'" + ") </script>");
                                txtCodigo.Text = "";
                                //txtNombre.Text = "";
                                txtContraseña.Text = "";
                                DropUser.Text = "Seleccione";
                            }
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert (" + "'El numero de empleado no existe'" + ") </script>");
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        txtContraseña.Text = "";
                        DropUser.Text = "Seleccione";
                    }
                }

            }
        }

        public void VerificaEmpleado(string NumeroE)
        {
            using (TG24Entities context = new TG24Entities())
            {
                var Vusuario = context.Empprin.Where(e => e.CLAVE == NumeroE).ToList();
                if (Vusuario.Count == 0)
                {
                    Response.Write("<script>alert (" + "'El numero de empleado no existe'" + ") </script>");
                   
                    txtCodigo.Text = "";
                    txtContraseña.Text = "";
                }
                else { 
                foreach (Empprin emp in Vusuario)
                {

                    txtNombre.Text = emp.NOMBREN.Trim() + " " + emp.NOMBREP.Trim() + " " + emp.NOMBREM.Trim();
                }
            }
        }
     }

        public void GenerarContraseña()
        {
            Random rdn = new Random();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
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
            GenerarContraseña();
            VerificaEmpleado(txtCodigo.Text);
        }

        protected void GridContra_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Actualizar":
                    using (RECIBOSEntities2 db = new RECIBOSEntities2())
                    {
                        string empleado = e.Item.Cells[1].Text;
                        string nombre = e.Item.Cells[2].Text;
                        //var eliminar = from x in db.Usuarios where x.Empleado == empleado select x;
                        //db.Usuarios.RemoveRange(eliminar);
                        //db.SaveChanges();
                        //Response.Write("<script>alert (" + "'Usuario eliminado'" + ") </script>");
                        MultiviewP.ActiveViewIndex = 2;
                        lblCodE.Text = empleado;
                        lblNombE.Text = nombre;

                    }   
                    break;
            }
        }

        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            VerificaEmpleado(txtCodigo.Text);
            GenerarContraseña();
            this.DropUser.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (RECIBOSEntities2 db = new RECIBOSEntities2())
            {
                if (txtContra.Text == "")
                {
                    Response.Write("<script>alert (" + "'Favor de Ingresar la contraseña nueva. '" + ") </script>");
                }
                else
                {
                    db.ActualizaContraseña(lblCodE.Text, txtContra.Text);
                    Response.Write("<script>alert (" + "'Contraseña Reestablecida'" + ") </script>");
                }
            }
            MultiviewP.ActiveViewIndex = 1;
        }

        protected void GridContra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

  
}

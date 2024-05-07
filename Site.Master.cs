using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VNominas
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                menu();
            }
        }
        private void menu()
        {


        }
        public void menu2()
        {
        } 
      
        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, System.Web.UI.WebControls.MenuEventArgs e)
        {
            menu2();
        }

        protected void Menu1_DataBinding(object sender, EventArgs e)
        {
           
        }

        public void Menu1_MenuItemClick1(object sender, MenuEventArgs e)
        {
          
            if (Menu1.SelectedValue == "INICIO")
            {
                Page.Response.Redirect("Principal.aspx");
            }
        }


        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu2.SelectedValue == "SALIR")
            {
                HttpContext.Current.Session.Abandon();
                HttpContext.Current.Response.Cookies.Add(new HttpCookie("Empleado", ""));
                Session.Abandon();
                Session.Clear();
                Page.Response.Redirect("Default.aspx");
            }
        }
    }


}

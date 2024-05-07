using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VNominas
{
    public class Archivos
    {
        public string Nomina{ get; set; }
        public string Ver { get; set; }
    }

    public class Login
    {
        public static int IniciarSesion(string Empleado, string Contraseña)
        {
            RECIBOSEntities2 db = new RECIBOSEntities2();
            int usuario = 0;

            //var consulta = db.Usuarios.Where(p => p.Empleado == Empleado && p.Contraseña == Contraseña).Select(p => p);
            var consulta = db.sp_Contraseñas(Empleado,Contraseña);
           
            if (consulta.First() == 0){
                usuario = 0;
             }else{
                usuario = 1;
            }
               
            return usuario;
        }
    }


    public class Buscar
    {
        public static int BuscarEmp (string Codigo)
        {
            RECIBOSEntities2 db = new RECIBOSEntities2();
            int empleado = 0;
            var consulta = db.Usuarios.Where(p => p.Empleado == Codigo).Select(p => p);

            if (consulta.Count() > 0)
                empleado = consulta.First().ID;
            return empleado;
        }
    }
}
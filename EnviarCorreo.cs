using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Web.UI.WebControls;
using System.Data;

namespace VNominas
{
    public class EnviarCorreo
    {
        MailMessage Correo = new MailMessage();
        SmtpClient Enviar = new SmtpClient();

        public void EnviarCorreos(string emisor, string correoDes, string Archivo)
        {
            try
            {
                Correo.To.Clear();
                Correo.Body = "";
                Correo.Subject = "";
                Correo.To.Add(correoDes.Trim());
                if(Archivo.Equals("") == false)
                {
                    System.Net.Mail.Attachment adjunto = new System.Net.Mail.Attachment(Archivo);
                    Correo.Attachments.Add(adjunto);
                }

                Correo.From = new MailAddress(emisor);
                Enviar.Credentials = new NetworkCredential("erick.hernandez1912@gmail.com", "TGhd2525");

                Enviar.Host = "sntp.gmail.com";
                Enviar.Port = 587;
                Enviar.EnableSsl = true;

                Enviar.Send(Correo);
                
            }catch(Exception ex)
            {
                
            }


        return;
        }


    }

   






}
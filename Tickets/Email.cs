using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;
using Elmah;
using System.Net;

namespace Tickets
{
    public partial class Email
    {       
        public bool Enviar(String asunto, String mensaje, String direccion)
        {
            bool resultado = false;
            MailMessage correo = new MailMessage();            
            correo.From = new MailAddress("estefvera2018@gmail.com");            
            correo.To.Add(new MailAddress(direccion));            
            MailAddress bcc = new MailAddress("tengofree@gmail.com");
            correo.Bcc.Add(bcc);
            correo.Subject = asunto;
            correo.Body = mensaje;
           
            SmtpClient smtp = new SmtpClient();
           
            try
            {
                smtp.Send(correo);
                resultado = true;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
            }
            return resultado;
        }
    }
}

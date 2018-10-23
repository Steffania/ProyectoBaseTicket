using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

namespace Tickets
{
    public partial class Nuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnReportar_Click(object sender, EventArgs e)
        {
            //Crea objeto Ticket
            BaseTicketRules.Entities.Tickets ticket = new BaseTicketRules.Entities.Tickets();
            ticket.AreaId = Convert.ToInt32(comboBoxArea.SelectedItem.Value);
            ticket.Apellido = TextBoxApellido.Text;
            ticket.Nombre = TextBoxNombre.Text;
            ticket.Email = TextBoxEmail.Text;
            ticket.FechaTicket = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            ticket.Telefono = TextBoxTelefono.Text;
            ticket.Descripcion = memoDescripcion.Text;

            //Genera codigo de ticket de 4 digitos de manera aleatoria (comprendido entre 1 y 99999)
            int numero = 0;            
            numero = GetNumeroAleatorio();

            //Verifica si el codigo aleatorio generado existe en la base de datos
            BaseTicketRules.Objects.vw_TicketsObjectList listaTickets = BaseTicketRules.Mappers.vw_TicketsMapper.Instance().GetByNumero(string.Format("{0:0000}", numero));
            if (listaTickets.Count == 0)
            {               
                //Envia el email
                Enviar(string.Format("{0:0000}", numero));
                ticket.Numero = string.Format("{0:0000}", numero);
                try
                {
                    //Inserta el registro en la base de datos
                    BaseTicketRules.Mappers.TicketsMapper.Instance().Insert(ticket);
                }
                catch (Exception)
                {
                    throw;
                }
            }  
        }
        private static int GetNumeroAleatorio()
        {            
            Random r = new Random();
            int numero = r.Next(1, 99999);
            return numero;
        }
        private void Enviar(string numero)
        {
            bool bolEnviado = false;
            string strAsunto = "";
            strAsunto = "[Ticket - " + numero + "] Reporte de Error (" + TextBoxNombre.Text + ", " + TextBoxApellido.Text + ")";
            Email email = new Email();
            try
            {
                bolEnviado = email.Enviar(strAsunto, MensajeArmar(), TextBoxEmail.Text);
                TextBoxNombre.Text = "";
                TextBoxApellido.Text = "";
                comboBoxArea.SelectedIndex = -1;
                TextBoxTelefono.Text = "";
                TextBoxEmail.Text = "";
                memoDescripcion.Text = "";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El error ha sido reportado con exito. Una copia del mismo ha sido enviado a su correo electrónico.');", true);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private string MensajeArmar()
        {
            System.Text.StringBuilder msj = new System.Text.StringBuilder();
            msj.Append("TICKET - Reporte de Error");
            msj.Append(Environment.NewLine);
            msj.Append("-------------------------------------------------------------------");
            msj.Append(Environment.NewLine);
            msj.Append("Area: ");
            msj.Append(comboBoxArea.SelectedItem);
            msj.Append(Environment.NewLine);
            msj.Append("Nombre: ");
            msj.Append(TextBoxNombre.Text);
            msj.Append(Environment.NewLine);
            msj.Append("Apellido: ");
            msj.Append(TextBoxApellido.Text);
            msj.Append(Environment.NewLine);
            msj.Append("Telefono: ");
            msj.Append(TextBoxTelefono.Text);
            msj.Append(Environment.NewLine);
            msj.Append("Email: ");
            msj.Append(TextBoxEmail.Text);
            msj.Append(Environment.NewLine);
            msj.Append("Descripción: ");
            msj.Append(memoDescripcion.Text);
            return msj.ToString();
        }
    }
}
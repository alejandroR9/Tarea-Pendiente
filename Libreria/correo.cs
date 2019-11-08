using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class correo : Form
    {
        public correo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(txtpara.Text);
            mmsg.Subject = txtasun.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(txtbo.Text);
            mmsg.Body = txtmensaje.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("howtorock.tlv@gmail.com");
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("howtorock.tlv@gmail.com", "alejandro123456789");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "sntp.gmail.com";//mail.dominio.com

            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");

            }

        }
    }
}

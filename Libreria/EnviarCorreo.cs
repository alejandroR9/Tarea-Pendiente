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
    public partial class EnviarCorreo : Form
    {
        public EnviarCorreo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(txtpara.Text);
            mmsg.Subject = txtasun.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Bcc.Add(txtboc.Text);
            mmsg.Body = txtmensaje.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;




        }
    }
}

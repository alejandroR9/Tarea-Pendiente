using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = C:/Users/Usuario/Desktop/BDSolIV/tarea.xlsx;Extended Properties = \"Excel 8.0;HDR = Yes\"";
            OleDbConnection conectar = default(OleDbConnection);
            conectar = new OleDbConnection(conexion);
            conectar.Open();

            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("Select * from [LIBROS FÍSICOS MATRZ$]",conectar);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            conectar.Close();
        }
    }
}

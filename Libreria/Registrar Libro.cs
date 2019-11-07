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
using Microsoft.Office.Interop.Excel;

namespace Libreria
{
    public partial class Registrar_Libro : Form
    {
        public Registrar_Libro()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = C:/Users/Usuario/Desktop/BDSolIV/tarea.xlsx;Extended Properties = \"Excel 8.0;HDR = Yes\"";
            OleDbConnection conectar = default(OleDbConnection);
            conectar = new OleDbConnection(conexion);
            conectar.Open();

            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("Select * from [LIBROS FÍSICOS MATRZ$]", conectar);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            conectar.Close();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            exportaraexcel(dataGridView1);
        }

        public void exportaraexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();


            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void Registrar_Libro_Load(object sender, EventArgs e)
        {

        }
    }
    
}

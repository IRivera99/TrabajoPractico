using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Dominio;

namespace WindowsFormsApp2.Formularios
{
    public partial class frmReporteCarreras : Form
    {
        DataTable tabla = new DataTable();
        SqlConnection cnn = new SqlConnection(@"Data Source=NACHO\SQLEXPRESS01;Initial Catalog=CarreraDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        bool flag = false;

        public frmReporteCarreras()
        {
            InitializeComponent();
        }

        private void frmReporteCarreras_Load(object sender, EventArgs e)
        {
            CargarCarreras();
        }

        private void CargarCarreras()
        {            
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CONSULTAR_CARRERAS";
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            cboCarreras.DataSource = tabla;
            cboCarreras.DisplayMember = tabla.Columns[1].ColumnName;
            cboCarreras.ValueMember = tabla.Columns[0].ColumnName;
            cboCarreras.SelectedIndex = -1;
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cboCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCarreras.SelectedIndex > -1 && flag)
            {
                int id = (int)cboCarreras.SelectedValue;

                SqlConnection cnn = new SqlConnection(@"Data Source=NACHO\SQLEXPRESS01;Initial Catalog=CarreraDB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CONSULTAR_CARRERA_POR_IDREPORTE";
                cmd.Parameters.AddWithValue("@idCarrera", id);

                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));
                reportViewer1.RefreshReport();

                cnn.Close();
            }
        }
    }
}

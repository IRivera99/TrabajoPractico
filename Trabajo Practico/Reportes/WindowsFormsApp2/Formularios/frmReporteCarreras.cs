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

namespace WindowsFormsApp2.Formularios
{
    public partial class frmReporteCarreras : Form
    {
        public frmReporteCarreras()
        {
            InitializeComponent();
        }

        private void frmReporteCarreras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSCarreras1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dSCarreras1.DataTable1);
            // TODO: esta línea de código carga datos en la tabla 'dSCarreras.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.dSCarreras.DataTable1);

            this.reportViewer1.RefreshReport();

           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}

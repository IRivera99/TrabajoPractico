using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Formularios
{
    public partial class frmReporteAsignaturas : Form
    {
        public frmReporteAsignaturas()
        {
            InitializeComponent();
        }

        private void frmReporteAsignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMaterias.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.dSMaterias.Asignaturas);
            
            this.reportViewer2.RefreshReport();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

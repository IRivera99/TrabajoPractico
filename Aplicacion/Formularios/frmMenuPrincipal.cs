using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tsmCrearAsignatura_Click(object sender, EventArgs e)
        {
            frmAltaAsignaturas frmAltaAsignaturas = new frmAltaAsignaturas();
            frmAltaAsignaturas.ShowDialog();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de la sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsmModificarAsignaturas_Click(object sender, EventArgs e)
        {
            frmModificarAsignaturas frmModificarAsignaturas = new frmModificarAsignaturas();
            frmModificarAsignaturas.ShowDialog();
        }

        private void tsmCarreras_Click(object sender, EventArgs e)
        {
            frmCarreras frmCarrera = new frmCarreras();
            frmCarrera.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

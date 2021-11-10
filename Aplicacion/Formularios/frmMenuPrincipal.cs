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
        int locX, locY, alto;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }        

        private void btnSesion_Click(object sender, EventArgs e)
        {
            if (pSesion.Visible)
            {
                ocultarPaneles();
                posicionesOriginales();
            }
            else
            {
                ocultarPaneles();
                posicionesOriginales();
                pSesion.Visible = true;
                btnAsignaturas.Location = new Point(locX, locY + (alto * 2));
                btnCarreras.Location = new Point(locX, locY + (alto * 3));
                btnAcerca.Location = new Point(locX, locY + (alto * 4));
            }            
        }      
        
        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            if (pAsignaturas.Visible)
            {
                ocultarPaneles();
                posicionesOriginales();
            }
            else
            {
                ocultarPaneles();
                posicionesOriginales();
                pAsignaturas.Visible = true;                
                btnCarreras.Location = new Point(locX, locY + (alto*2) + (alto * 2));
                btnAcerca.Location = new Point(locX, locY + (alto*3) + (alto * 2));
            }
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            if (pCarreras.Visible)
            {
                ocultarPaneles();
                posicionesOriginales();
            }
            else
            {
                ocultarPaneles();
                posicionesOriginales();
                pCarreras.Visible = true;
                btnAcerca.Location = new Point(locX, locY + (alto*3) + alto);
            }
        }
        
        private void btnAcerca_Click(object sender, EventArgs e)
        {
            if (pAcerca.Visible)
            {
                ocultarPaneles();
                posicionesOriginales();
            }
            else
            {
                ocultarPaneles();
                posicionesOriginales();
                pAcerca.Visible = true;
            }
        }

        private void posicionesOriginales()
        {
            btnSesion.Location = new Point(locX, locY);
            btnAsignaturas.Location = new Point(locX, locY + alto);
            btnCarreras.Location = new Point(locX, locY + (alto*2));
            btnAcerca.Location = new Point(locX, locY + (alto*3));
        }

        private void ocultarPaneles()
        {
            pAcerca.Visible = pAsignaturas.Visible = pCarreras.Visible = pSesion.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de la sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                posicionesOriginales();
                ocultarPaneles();
                this.Close();
            }
        }

        private void btnAltaA_Click(object sender, EventArgs e)
        {
            posicionesOriginales();
            ocultarPaneles();
            frmAltaAsignaturas frmAltaAsignaturas = new frmAltaAsignaturas();
            frmAltaAsignaturas.ShowDialog();
        }

        private void btnModA_Click(object sender, EventArgs e)
        {
            posicionesOriginales();
            ocultarPaneles();
            frmModificarAsignaturas frmModificarAsignaturas = new frmModificarAsignaturas();
            frmModificarAsignaturas.ShowDialog();
        }

        private void btnGestorC_Click(object sender, EventArgs e)
        {
            posicionesOriginales();
            ocultarPaneles();
            frmCarreras frmCarrera = new frmCarreras();
            frmCarrera.ShowDialog();
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            posicionesOriginales();
            ocultarPaneles();
            MessageBox.Show("Agustin Rematar\nIgnacio Rivera\nAdrian Vela\nTomas Quinteros", "Integrantes", MessageBoxButtons.OK);
            return;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            locX = 41;
            locY = 75;
            alto = 37;
        }
    }
}

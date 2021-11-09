using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.Cliente;
using LibreriaDatos.Dominio;
using Newtonsoft.Json;

namespace Aplicacion.Formularios
{
    public partial class frmAltaAsignaturas : Form
    {
        List<Asignatura> listaAsignaturas = new List<Asignatura>();
        Asignatura asignatura;
        int ultimoLista = -1;

        public object JasonConvert { get; private set; }

        public frmAltaAsignaturas()
        {
            InitializeComponent();
        }

        private async void frmAltaAsignaturas_Load(object sender, EventArgs e)
        {
            btnVolver.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = false;
            await CargarListaAsync();
            VerificarVolver();
            lstAsignaturas.SelectedIndex = -1;           
        }

        private async Task CargarListaAsync()
        {
            lstAsignaturas.Items.Clear();

            string url = "https://localhost:44351/ConsultarAsignaturas";
            List<Asignatura> lista = null;
            var resultado = await ClienteSingleton.ObtenerInstancia().ConsultarAsync(url);
            lista = JsonConvert.DeserializeObject<List<Asignatura>>(resultado);

            foreach (Asignatura item in lista)
            {
                lstAsignaturas.Items.Add(item);
            }
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            if (listaAsignaturas.Count == 0)
            {
                MessageBox.Show("Para grabar debe ingresar una asignatura", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            
            string asignaturasJson = JsonConvert.SerializeObject(listaAsignaturas);
            string url = "https://localhost:44351/InsertarAsignaturas";
            bool verficarTransaccion;
            var resultado = await ClienteSingleton.ObtenerInstancia().InsertarAsync(url, asignaturasJson);
            verficarTransaccion = JsonConvert.DeserializeObject<bool>(resultado);

            if (verficarTransaccion)
            {
                MessageBox.Show("Asignaturas grabadas con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al intentar grabar asignaturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar los cambios realizados?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listaAsignaturas.Clear();
                ultimoLista = -1;
                btnVolver.Enabled = false;
                await CargarListaAsync();                
                lstAsignaturas.SelectedIndex = -1;            
                VerificarVolver();
                btnVolver.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para la asignatura", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            foreach (Asignatura item in lstAsignaturas.Items)
            {
                if (txtNombre.Text == item.Nombre)
                {
                    MessageBox.Show("No puede ingresar una asignatura ya existente", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                    return;
                }
            }
            asignatura = new Asignatura();

            asignatura.Nombre = txtNombre.Text;
            asignatura.IdAsignatura = 0;
            lstAsignaturas.Items.Add(asignatura);
            listaAsignaturas.Add(asignatura);
            ultimoLista++;
            VerificarVolver();
            txtNombre.Text = "";

            btnGrabar.Enabled = true;
        }

        private void VerificarVolver()
        {
            if (listaAsignaturas.Count == 0)
            { btnVolver.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = false; }
            else { btnVolver.Enabled = btnGrabar.Enabled = btnCancelar.Enabled = true; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            int ind = -1;
            foreach (Asignatura item in lstAsignaturas.Items)
            {
                if (item.Nombre.Equals(listaAsignaturas[ultimoLista].Nombre))
                {
                    ind = lstAsignaturas.Items.IndexOf(item);
                }
            }
            lstAsignaturas.Items.RemoveAt(ind);
            listaAsignaturas.RemoveAt(ultimoLista);
            ultimoLista--;
            VerificarVolver();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea volver al menú principal? Se descartarán los datos que no hayan sido guardados...", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}

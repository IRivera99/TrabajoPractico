using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDatos.Dominio;
using Aplicacion.Cliente;
using Newtonsoft.Json;

namespace Aplicacion.Formularios
{
    public partial class frmModificarAsignaturas : Form
    {
        Asignatura asignatura;
        List<int> listaID = new List<int>();
        List<int> listaBorrado = new List<int>();
        List<int> listaModificadoID = new List<int>();
        List<Asignatura> listaModificado = new List<Asignatura>();
        bool modificar = false;
        bool quitar = false;

        public frmModificarAsignaturas()
        {
            InitializeComponent();
            lstAsignaturas.SelectedIndex = -1;
            btnQuitar.Enabled = btnModificar.Enabled = false;
        }

        private async void frmModificarAsignaturas_Load(object sender, EventArgs e)
        {
            await CargarLista();
            btnCancelar.Enabled = btnGuardar.Enabled = false;
        }
                
        private async Task CargarLista()
        {
            lstAsignaturas.Items.Clear();
            string urlAsignatura = "https://localhost:44351/ConsultarAsignaturas";
            string urlId = "https://localhost:44351/ConsultarIdAsignaturas";

            List<Asignatura> listaAsignaturas = null;
            List<int> listaId = null;

            var resultadoAsignaturas = await ClienteSingleton.ObtenerInstancia().ConsultarAsync(urlAsignatura);
            listaAsignaturas = JsonConvert.DeserializeObject<List<Asignatura>>(resultadoAsignaturas);

            var resultadoId = await ClienteSingleton.ObtenerInstancia().ConsultarAsync(urlId);
            listaId = JsonConvert.DeserializeObject<List<int>>(resultadoId);

            foreach (Asignatura asignatura in listaAsignaturas)
            {
                lstAsignaturas.Items.Add(asignatura);
            }
            foreach (int id in listaId)
            {
                listaID.Add(id);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar y volver al menú principal?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                listaBorrado.Clear(); listaID.Clear(); listaModificado.Clear(); listaModificadoID.Clear();
                await CargarLista();
                btnCancelar.Enabled = btnGuardar.Enabled = false;
            }
        }

        private void lstAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAsignaturas.SelectedIndex > -1)
            {
                txtNombre.Text = lstAsignaturas.SelectedItem.ToString();
            }
            btnQuitar.Enabled = btnModificar.Enabled = true;

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaModificadoID.Count; i++)
            {
                if (listaModificadoID[i] == listaID[lstAsignaturas.SelectedIndex])
                {
                    listaModificadoID.RemoveAt(i);
                    listaModificado.RemoveAt(i);
                }
            }
            listaBorrado.Add(listaID[lstAsignaturas.SelectedIndex]);
            listaID.RemoveAt(lstAsignaturas.SelectedIndex);
            lstAsignaturas.Items.RemoveAt(lstAsignaturas.SelectedIndex);
            txtNombre.Text = "";
            btnCancelar.Enabled = btnGuardar.Enabled = true;
            quitar = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para la asignatura", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            if (lstAsignaturas.FindStringExact(txtNombre.Text) >= 0)
            {
                MessageBox.Show("No puede ingresar una asignatura ya existente", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            asignatura = new Asignatura();
            asignatura.Nombre = txtNombre.Text;
            int indice = lstAsignaturas.SelectedIndex;
            int Id_bckp = listaID[indice];
            asignatura.IdAsignatura = Id_bckp;

            listaModificadoID.Add(listaID[indice]);
            listaModificado.Add(asignatura);

            lstAsignaturas.Items.RemoveAt(indice);
            lstAsignaturas.Items.Add(asignatura);

            listaID.RemoveAt(indice);
            listaID.Insert(BuscarIndice(asignatura.Nombre), Id_bckp);

            lstAsignaturas.SelectedIndex = -1;
            indice = -1;
            btnModificar.Enabled = false;
            txtNombre.Text = string.Empty;
            lstAsignaturas.Focus();
            btnCancelar.Enabled = btnGuardar.Enabled = true;
            modificar = true;
        }

        private int BuscarIndice(string nAsignatura)
        {
            int indice = lstAsignaturas.FindStringExact(txtNombre.Text);
            return indice;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (listaModificadoID.Count == 0)
            {
                modificar = false;
            }

            string urlQuitar = "";
            string urlModificar = "https://localhost:44351/ModificarAsignaturas";            

            if (quitar && !modificar)
            {
                bool resultado = false;

                foreach (int id in listaBorrado)
                {
                    urlQuitar = "https://localhost:44351/BorrarAsignaturas/"+id.ToString();
                    var resultadoQuitar = await ClienteSingleton.ObtenerInstancia().BorrarAsync(urlQuitar);
                    resultado = JsonConvert.DeserializeObject<bool>(resultadoQuitar);
                }

                if (resultado)
                {
                    MessageBox.Show("Asignaturas grabadas con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar grabar asignaturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (modificar && !quitar)
            {
                string listaModificarJson = JsonConvert.SerializeObject(listaModificado);
                var resultadoModificar = await ClienteSingleton.ObtenerInstancia().ModificarAsync(urlModificar, listaModificarJson);
                var resultado = JsonConvert.DeserializeObject<bool>(resultadoModificar);

                if (resultado)
                {
                    MessageBox.Show("Asignaturas grabadas con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar grabar asignaturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (modificar && quitar)
            {
                string listaModificarJson = JsonConvert.SerializeObject(listaModificado);
                var resultadoModificar = await ClienteSingleton.ObtenerInstancia().ModificarAsync(urlModificar, listaModificarJson);
                var resultadoM = JsonConvert.DeserializeObject<bool>(resultadoModificar);

                bool resultadoQ = false;

                foreach (int id in listaBorrado)
                {
                    urlQuitar = "https://localhost:44351/BorrarAsignaturas/" + id.ToString();
                    var resultadoQuitar = await ClienteSingleton.ObtenerInstancia().BorrarAsync(urlQuitar);
                    resultadoQ = JsonConvert.DeserializeObject<bool>(resultadoQuitar);
                }
                if (resultadoM && resultadoQ)
                {
                    MessageBox.Show("Asignaturas grabadas con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar grabar asignaturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
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

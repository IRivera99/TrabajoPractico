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
using LibreriaDatos.Servicios;
using Aplicacion.Cliente;
using Newtonsoft.Json;

namespace Aplicacion.Formularios
{
    public partial class frmCarreras : Form
    {
        Parametros.Accion modo;
        Carrera oCarrera = new Carrera();
        List<int> listaIdCarrera = new List<int>();

        public frmCarreras()
        {
            InitializeComponent();
        }

        private async void Alta_Carreras_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();
            await CargarListaCarrerasAsync();
            dgvAsignaturas.Rows.Clear();
            cboAsignatura.SelectedIndex = -1;
            btnModificar.Enabled = btnQuitar.Enabled = false;
            modo = Parametros.Accion.Crear;
        }

        private async Task CargarListaCarrerasAsync()
        {
            string urlCarreras = "https://localhost:44351/ConsularCarreras";
            string urlIdCarreras = "https://localhost:44351/ConsultarIdCarreras";

            List<Carrera> listaCarreras = null;
            List<int> listaId = null;

            var resultadoCarreras = await ClienteSingleton.ObtenerInstancia().ConsultarAsync(urlCarreras);
            listaCarreras = JsonConvert.DeserializeObject<List<Carrera>>(resultadoCarreras);

            var resultadosId = await ClienteSingleton.ObtenerInstancia().ConsultarAsync(urlIdCarreras);
            listaId = JsonConvert.DeserializeObject<List<int>>(resultadosId);

            foreach (Carrera item in listaCarreras)
            {
                lstCarreras.Items.Add(item.Nombre);
            }
            foreach (int item in listaId)
            {
                listaIdCarrera.Add(item);
            }
        }

        private async Task CargarComboAsync()
        {
            string url = "https://localhost:44351/ConsultarAsignaturas";
            List<Asignatura> lista = null;
            var resultado = await ClienteSingleton.ObtenerInstancia().ConsultarAsync(url);
            lista = JsonConvert.DeserializeObject<List<Asignatura>>(resultado);

            cboAsignatura.DataSource = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!rbt1C.Checked && !rbt2C.Checked && !rbtAnual.Checked)
            {
                MessageBox.Show("Debe ingresar a que cuatrimestre pertenece la materia...", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (VerificarExiste(cboAsignatura.Text))
            {
                MessageBox.Show("Asignatura ya agregada a la carrera... Ingrese otra...", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleCarrera detalle = new DetalleCarrera();
            string cuatrimestre;

            Asignatura oAsignatura = (Asignatura)cboAsignatura.SelectedItem;

            detalle.Asignatura = oAsignatura;
            detalle.Año = (int)nudAño.Value;
            if (rbt1C.Checked) { detalle.Cuatrimestre = 1; cuatrimestre = "1er"; }
            else if (rbt2C.Checked) { detalle.Cuatrimestre = 2; cuatrimestre = "2do"; }
            else { detalle.Cuatrimestre = 3; cuatrimestre = "Anual"; }

            oCarrera.AgregarAsignatura(detalle);
            dgvAsignaturas.Rows.Add(new object[] { "", oAsignatura.Nombre, nudAño.Value, cuatrimestre });

            nudAño.Value = 1;
            cboAsignatura.SelectedIndex = -1;
            rbt1C.Checked = rbt2C.Checked = rbtAnual.Checked = false;
        }

        private bool VerificarExiste(string nombre)
        {
            foreach (DataGridViewRow item in dgvAsignaturas.Rows)
            {
                if (item.Cells[1].Value.ToString() == nombre)
                    return true;
            }
            return false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string exito = string.Empty;
            string error = string.Empty;

            lstCarreras.Enabled = true;            

            if (txtNombre.Text.Equals(string.Empty))
            {
                MessageBox.Show("Especifique el nombre de la carrera...", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (txtTitulo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Especifique el titulo recibido...", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitulo.Focus();
                return;
            }
            if (dgvAsignaturas.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una materia para crear una carrera...", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string urlCrear = "https://localhost:44351/InsertarCarreras";
            string urlModificar = "https://localhost:44351/ModificarCarreras";

            oCarrera.Nombre = txtNombre.Text;
            oCarrera.Titulo = txtTitulo.Text;

            string carreraJson = JsonConvert.SerializeObject(oCarrera);
            bool verificarTransaccion = false;

            if (modo == Parametros.Accion.Modificar)
            {
                var resultado = await ClienteSingleton.ObtenerInstancia().ModificarAsync(urlModificar, carreraJson);
                verificarTransaccion = JsonConvert.DeserializeObject<bool>(resultado);
                exito = "Carrera modificada con éxito!";
                error = "No se ha podido modificar la carrera...";
               
            }
            if (modo == Parametros.Accion.Crear)
            {
                var resultado = await ClienteSingleton.ObtenerInstancia().InsertarAsync(urlCrear, carreraJson);
                verificarTransaccion = JsonConvert.DeserializeObject<bool>(resultado);
                exito = "Carrera creada con éxito!";
                error = "No se ha podido crear la carrera...";                
            }
            if (verificarTransaccion)
            {
                MessageBox.Show(exito, "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstCarreras.Items.Clear();
                listaIdCarrera.Clear();
                await CargarListaCarrerasAsync();
                oCarrera = new Carrera();
                txtNombre.Text = string.Empty;
                txtTitulo.Text = string.Empty;
                cboAsignatura.SelectedIndex = -1;
                nudAño.Value = 1;
                rbt1C.Checked = rbt2C.Checked = rbtAnual.Checked = false;
                dgvAsignaturas.Rows.Clear();
                modo = Parametros.Accion.Crear;
            }
            else
            {
                MessageBox.Show(error, "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAsignaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAsignaturas.CurrentCell.ColumnIndex == 4)
            {
                oCarrera.QuitarAsignatura(dgvAsignaturas.CurrentRow.Index);
                dgvAsignaturas.Rows.Remove(dgvAsignaturas.CurrentRow);
            }
        }

        private void lstCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCarreras.SelectedIndex > -1)
            {
                oCarrera.IdCarrera = listaIdCarrera[lstCarreras.SelectedIndex];
            }
            btnQuitar.Enabled = btnModificar.Enabled = true;
        }

        private async void btnQuitar_Click(object sender, EventArgs e)
        {
            string urlQuitar = "https://localhost:44351/BorrarCarreras/"+oCarrera.IdCarrera.ToString();
            bool resultado = false;

            DialogResult result = MessageBox.Show("¿Desea eliminar esta carrera?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var resultadoQuitar = await ClienteSingleton.ObtenerInstancia().BorrarAsync(urlQuitar);
                resultado = JsonConvert.DeserializeObject<bool>(resultadoQuitar);
                if (resultado)
                {
                    MessageBox.Show("Carrera borrada con éxito...", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstCarreras.Items.Clear();
                    listaIdCarrera.Clear();
                    await CargarListaCarrerasAsync();
                    oCarrera = new Carrera();
                    txtNombre.Text = string.Empty;
                    txtTitulo.Text = string.Empty;
                    cboAsignatura.SelectedIndex = -1;
                    nudAño.Value = 1;
                    rbt1C.Checked = rbt2C.Checked = rbtAnual.Checked = false;
                    dgvAsignaturas.Rows.Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Error al intentar borrar la carrera...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            string urlConsultarPorId = "https://localhost:44351/ConsultarCarerraPorId/"+oCarrera.IdCarrera.ToString();            

            var resultado = await ClienteSingleton.ObtenerInstancia().ConsultarAsync(urlConsultarPorId);
            oCarrera = JsonConvert.DeserializeObject<Carrera>(resultado);

            txtNombre.Text = oCarrera.Nombre;
            txtTitulo.Text = oCarrera.Titulo;
            string cuatrimestre;

            foreach (DetalleCarrera item in oCarrera.DetalleCarrera)
            {
                if (item.Cuatrimestre == 1)
                {
                    cuatrimestre = "1er";
                }
                else if (item.Cuatrimestre == 2)
                {
                    cuatrimestre = "2do";
                }
                else { cuatrimestre = "Anual"; }
                dgvAsignaturas.Rows.Insert(0, item.Asignatura.IdAsignatura, item.Asignatura.Nombre, item.Año, cuatrimestre); ;
            }

            dgvAsignaturas.Sort(dgvAsignaturas.Columns["Nombre"], ListSortDirection.Ascending);
            dgvAsignaturas.Sort(dgvAsignaturas.Columns["Cuatrimestre"], ListSortDirection.Ascending);
            dgvAsignaturas.Sort(dgvAsignaturas.Columns["Año"], ListSortDirection.Ascending);
            modo = Parametros.Accion.Modificar;
            btnModificar.Enabled = btnQuitar.Enabled = lstCarreras.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea limpiar los campos?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetDatos();
            }
        }

        private void ResetDatos()
        {
            oCarrera = new Carrera();
            txtNombre.Text = txtTitulo.Text = string.Empty;            
            dgvAsignaturas.Rows.Clear();
            rbt1C.Checked = rbt2C.Checked = rbtAnual.Checked = false;
            modo = Parametros.Accion.Crear;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar y volver al menú principal?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void lstCarreras_LostFocus(object sender, EventArgs e)
        {
            lstCarreras.ClearSelected();
        }
    }
}

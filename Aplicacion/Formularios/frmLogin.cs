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
using Newtonsoft.Json;
using Aplicacion.Cliente;

namespace Aplicacion.Formularios
{
    public partial class frmLogin : Form
    {
        private Usuario oUsuario = new Usuario();

        public frmLogin()
        {
            InitializeComponent();
            this.Show();            
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(string.Empty))
            {
                MessageBox.Show("Ingrese un nombre de usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtContraseña.Text.Equals(string.Empty))
            {
                MessageBox.Show("Ingrese la contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oUsuario.NUsuario = txtUsuario.Text;
            oUsuario.Contraseña = txtContraseña.Text;
            bool resultadoBusqueda = false;

            string urlConsultaUsuario = "https://localhost:44351/api/Usuarios/VerificarUsuario";

            string usuarioJson = JsonConvert.SerializeObject(oUsuario);
            var resultado = await ClienteSingleton.ObtenerInstancia().ConsultarUsuarioAsync(urlConsultaUsuario, usuarioJson);
            resultadoBusqueda = JsonConvert.DeserializeObject<bool>(resultado);

            if (resultadoBusqueda)
            {
                MessageBox.Show("Acceso concedido", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                frmMenuPrincipal.FormClosed += Logout;
                this.Hide();
                txtUsuario.Text = "Usuario";
                txtUsuario.Font = new System.Drawing.Font("Quicksand Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = '\0';
                txtContraseña.Font = new System.Drawing.Font("Quicksand Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);            
            return;
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            this.Show();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();                
            }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Usuario"))
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }                
        }
        private void txtUsuario_LostFocus(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(string.Empty))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.Font = new System.Drawing.Font("Quicksand Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);                
            }
        }
        private void txtContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals("Contraseña"))
            {
                txtContraseña.Text = string.Empty;
                txtContraseña.PasswordChar = '*';
                txtContraseña.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }
                
        }
        private void txtContraseña_LostFocus(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Equals(string.Empty))
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.PasswordChar = '\0';
                txtContraseña.Font = new System.Drawing.Font("Quicksand Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            txtContraseña.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
    }
}

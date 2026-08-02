using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Biblioteca1_Modelo;
using Biblioteca2_Datos;
using Biblioteca3_Negocio;

namespace MetaNova
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Resize(object sender, EventArgs e)
        {
            // Centrado dinamico del panel contenedor
            pnlContenedor.Location = new Point((this.ClientSize.Width - pnlContenedor.Width) / 2, (this.ClientSize.Height - pnlContenedor.Height) / 2);
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public string NombreUsuarioLogueado = "";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            UsuarioBLL usuarioBll = new UsuarioBLL();
            Usuario usuarioLogueado = usuarioBll.Login(nombre, contrasena);

            if (usuarioLogueado != null)
            {
                MessageBox.Show($"¡Bienvenido, {usuarioLogueado.Nombre}!", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- AGREGA ESTAS DOS LÍNEAS AQUÍ ---
                Menu_Principal menu = new Menu_Principal(usuarioLogueado.Nombre);
                menu.Show();
                // -------------------------------------



                // Señal para el Form principal antes de cerrar
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Clear();
                txtContrasena.Focus();
            }



        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
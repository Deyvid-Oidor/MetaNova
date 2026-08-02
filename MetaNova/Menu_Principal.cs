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

using MySql.Data.MySqlClient;

namespace MetaNova
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventario frmClientes = new Inventario();
            frmClientes.Show();
        }

        #region Hover Effects
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnPantallaClientes.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnPantallaClientes.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnPantallaClientes.BackColor = Color.FromArgb(241, 245, 249);
            btnPantallaClientes.ForeColor = Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnPantallaServicios.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnPantallaServicios.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnPantallaServicios.BackColor = Color.FromArgb(241, 245, 249);
            btnPantallaServicios.ForeColor = Color.Black;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            btnPantallaInventario.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnPantallaInventario.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnPantallaInventario.BackColor = Color.FromArgb(241, 245, 249);
            btnPantallaInventario.ForeColor = Color.Black;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(15, 23, 42);
            btnSalir.ForeColor = Color.FromArgb(203, 213, 225);
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPantallaServicios_Click(object sender, EventArgs e)
        {
            Servicio frmServicios = new Servicio();
            frmServicios.Show();
        }

        private void btnPantallaClientes_Click(object sender, EventArgs e)
        {
            Clientes_Equipos frmClientes = new Clientes_Equipos();
            frmClientes.Show();
        }

        private void btnPantallaReportes_Click(object sender, EventArgs e)
        {
            Reportes frmClientes = new Reportes();
            frmClientes.Show();
        }
      
        private void btnIrClientes_Click(object sender, EventArgs e)
        {
            Clientes_Equipos frm = new Clientes_Equipos();
            frm.Show();
            this.Hide();
        }

        private void btnIrServicio_Click(object sender, EventArgs e)
        {
            Servicio frm = new Servicio();
            frm.Show();
            this.Hide();
        }

        private void btnIrInventario_Click(object sender, EventArgs e)
        {
            Inventario frm = new Inventario();
            frm.Show();
            this.Hide();
        }

        private void btnIrUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
            this.Hide();
        }
        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            // Calcula un tamaño proporcional basado en el alto del TableLayoutPanel
            int alturaFila = tableLayoutPanel1.Height / 2;
            float tamanioBoton = alturaFila * 0.08f;
            float tamanioGroupBox = alturaFila * 0.055f; // Tamaño proporcional para el texto del GroupBox

            if (tamanioBoton < 10) tamanioBoton = 10;
            if (tamanioGroupBox < 8) tamanioGroupBox = 8;

            // Aplica el cambio de tamaño de fuente a los botones
            btnPantallaClientes.Font = new Font(btnPantallaClientes.Font.FontFamily, tamanioBoton, FontStyle.Bold);
            btnPantallaServicios.Font = new Font(btnPantallaServicios.Font.FontFamily, tamanioBoton, FontStyle.Bold);
            btnPantallaInventario.Font = new Font(btnPantallaInventario.Font.FontFamily, tamanioBoton, FontStyle.Bold);
            btnIrUsuarios.Font = new Font(btnIrUsuarios.Font.FontFamily, tamanioBoton, FontStyle.Bold);

            // Aplica el cambio de tamaño de fuente a los textos de los GroupBox
            groupBox1.Font = new Font(groupBox1.Font.FontFamily, tamanioGroupBox, FontStyle.Bold);
            groupBox2.Font = new Font(groupBox2.Font.FontFamily, tamanioGroupBox, FontStyle.Bold);
            groupBox3.Font = new Font(groupBox3.Font.FontFamily, tamanioGroupBox, FontStyle.Bold);
            groupBox4.Font = new Font(groupBox4.Font.FontFamily, tamanioGroupBox, FontStyle.Bold);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                Login login = new Login();
                login.Show();

                this.Close();
            }
        }

    }
}
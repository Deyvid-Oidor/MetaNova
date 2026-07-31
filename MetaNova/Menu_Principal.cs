// Agregar referencias
using Biblioteca1_Modelo;
using Biblioteca2_Datos;
using Biblioteca3_Negocio;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnPantallaClientes.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnPantallaClientes.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Cambia estos valores por los colores originales que tiene tu botón
            btnPantallaClientes.BackColor = Color.FromArgb(241, 245, 249);
            btnPantallaClientes.ForeColor = Color.Black;
        }


        //private void button2_MouseEnter(object sender, EventArgs e)
        //{
        //    button2.BackColor = ColorTranslator.FromHtml("#1E293B");
        //    button2.ForeColor = Color.White;
        //}


        //private void button2_MouseLeave(object sender, EventArgs e)
        //{
        //    button2.BackColor = Color.FromArgb(241, 245, 249); // Color base
        //    button2.ForeColor = Color.Black;
        //}

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnPantallaServicios.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnPantallaServicios.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnPantallaServicios.BackColor = Color.FromArgb(241, 245, 249); // Color base
            btnPantallaServicios.ForeColor = Color.Black;
        }


        private void button4_MouseEnter(object sender, EventArgs e)
        {
            btnPantallaInventario.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnPantallaInventario.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnPantallaInventario.BackColor = Color.FromArgb(241, 245, 249); // Color base
            btnPantallaInventario.ForeColor = Color.Black;
        }

        
        //private void button5_MouseEnter(object sender, EventArgs e)
        //{
        //    button5.BackColor = ColorTranslator.FromHtml("#1E293B");
        //    button5.ForeColor = Color.White;
        //}

        //private void button5_MouseLeave(object sender, EventArgs e)
        //{
        //    button5.BackColor = Color.FromArgb(241, 245, 249); // Color base
        //    button5.ForeColor = Color.Black;
        //}

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#1E293B");
            btnSalir.ForeColor = Color.White;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(15, 23, 42); // Color base oscuro
            btnSalir.ForeColor = Color.FromArgb(203, 213, 225); // Color gris claro (o rojo suave)
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación por completo (o puedes usar this.Close(); si solo quieres volver al Login)
            Application.Exit();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

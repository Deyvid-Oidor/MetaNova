using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar referencias
using Biblioteca1_Modelo;
using Biblioteca2_Datos;
using Biblioteca3_Negocio;

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

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#1E293B");
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Cambia estos valores por los colores originales que tiene tu botón
            button1.BackColor = Color.FromArgb(241, 245, 249);
            button1.ForeColor = Color.Black;
        }


        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#1E293B");
            button2.ForeColor = Color.White;
        }


        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(241, 245, 249); // Color base
            button2.ForeColor = Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#1E293B");
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(241, 245, 249); // Color base
            button3.ForeColor = Color.Black;
        }


        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = ColorTranslator.FromHtml("#1E293B");
            button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(241, 245, 249); // Color base
            button4.ForeColor = Color.Black;
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
    }
}

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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }




        private void Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Buscamos si el Menú Principal ya está abierto para volver a mostrarlo
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu_Principal)
                {
                    frm.Show();
                    return;
                }
            }

            // Si por alguna razón no estuviera en memoria, abrimos una nueva instancia del menú
            Menu_Principal menu = new Menu_Principal();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}

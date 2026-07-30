using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaNova
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos la ventana de Login
            Login frmLogin = new Login();

            // Muestra el Login como Diálogo. Si el resultado es OK, abre el Menú Principal
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Menu_Principal());
            }
        }
    }
}

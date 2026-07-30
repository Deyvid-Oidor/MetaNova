using Biblioteca1_Modelo;
using Biblioteca2_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca3_Negocio
{
    public class UsuarioBLL
    {
        // Regresa la lista de usuarios (técnicos y administrador), para llenar
        // el combo "Técnico Responsable" en la pantalla de Nueva Orden.
        // No necesita validación porque no se está capturando ningún dato aquí.
        public List<Usuario> ListarUsuarios()
        {
            return new UsuarioDAL().Listar();
        }

        // Valida el login: campos no vacíos, y que el usuario/contraseña exista en la BD
        public Usuario Login(string nombre, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Aviso");
                return null;
            }

            Usuario usuario = new UsuarioDAL().Login(nombre, contrasena);

            if (usuario == null)
                MessageBox.Show("Usuario o contraseña incorrectos.", "Aviso");

            return usuario;
        }

        public List<Usuario> ListarTecnicos()
        {
            UsuarioDAL dal = new UsuarioDAL();
            return dal.Listar();
        }

    } // Fin class
}

using Biblioteca1_Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2_Datos
{
    internal class UsuarioDAL
    {
        // Regresa la lista completa de usuarios (técnicos y administrador)
        // se usa para llenar el combo "Técnico Responsable" en la pantalla Nueva Orden
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader("SELECT id_usuario, nombre, rol FROM usuarios");
                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Usuario u = new Usuario();
                        u.IdUsuario = dr.GetInt32("id_usuario");
                        u.Nombre = dr.GetString("nombre");
                        u.Rol = dr.GetString("rol");
                        lista.Add(u);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

        // Valida usuario y contraseña para el login del sistema
        // regresa el Usuario si existe, o null si no encontró coincidencia
        public Usuario Login(string nombre, string contrasena)
        {
            Usuario usuario = null;
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "SELECT id_usuario, nombre, rol FROM usuarios WHERE nombre=@nombre AND contrasena=@contrasena");

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usuario = new Usuario();
                    usuario.IdUsuario = dr.GetInt32("id_usuario");
                    usuario.Nombre = dr.GetString("nombre");
                    usuario.Rol = dr.GetString("rol");
                }
                dr.Close();
                cn.desconectar();
            }
            return usuario;
        }

    } // Fin class
}

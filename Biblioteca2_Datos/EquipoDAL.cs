using MySql.Data.MySqlClient;
using Biblioteca1_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Biblioteca2_Datos
{
    public class EquipoDAL
    {
        // Inserta un nuevo equipo asociado a un cliente
        public int Insertar(Equipo eq)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "INSERT INTO equipos (id_cliente, id_Marca, modelo, numero_serie) " +
                    "VALUES (@idCliente, @idMarca, @modelo, @serie)");

                cmd.Parameters.AddWithValue("@idCliente", eq.IdCliente);
                cmd.Parameters.AddWithValue("@idMarca", eq.IdMarca);
                cmd.Parameters.AddWithValue("@modelo", eq.Modelo);
                cmd.Parameters.AddWithValue("@serie", eq.NumeroSerie);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }

        // Regresa los equipos que pertenecen a un cliente en específico
        // (se usa en la pantalla de Clientes/Equipos, al elegir un cliente de la lista)
        public List<Equipo> ListarPorCliente(int idCliente)
        {
            List<Equipo> lista = new List<Equipo>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                
                MySqlCommand cmd = cn.construye_command(
                    "SELECT e.id_equipo, e.id_cliente, e.id_Marca, e.modelo, e.numero_serie, m.nombre_marca " +
                    "FROM equipos e INNER JOIN marca m ON e.id_Marca = m.id_Marca " +
                    "WHERE e.id_cliente = @idCliente");

               
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Equipo eq = new Equipo();
                        eq.IdEquipo = dr.GetInt32("id_equipo");
                        eq.IdCliente = dr.GetInt32("id_cliente");
                        eq.IdMarca = dr.GetInt32("id_Marca");
                        eq.Modelo = dr.GetString("modelo");
                        eq.NumeroSerie = dr.IsDBNull(dr.GetOrdinal("numero_serie")) ? "" : dr.GetString("numero_serie");
                        eq.NombreMarca = dr.GetString("nombre_marca");
                        lista.Add(eq);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

        // Regresa el catálogo de marcas, para llenar el combo de "Marca" en las pantallas
        public List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader("SELECT id_Marca, nombre_marca FROM marca");
                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Marca m = new Marca();
                        m.IdMarca = dr.GetInt32("id_Marca");
                        m.NombreMarca = dr.GetString("nombre_marca");
                        lista.Add(m);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

        public bool EditarEquipo(Equipo equipo)
        {
            bool respuesta = false;
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "UPDATE equipos SET id_Marca = @idMarca, modelo = @modelo, numero_serie = @serie " +
                    "WHERE id_equipo = @idEquipo");

                cmd.Parameters.AddWithValue("@idMarca", equipo.IdMarca);
                cmd.Parameters.AddWithValue("@modelo", equipo.Modelo);
                cmd.Parameters.AddWithValue("@serie", equipo.NumeroSerie);
                cmd.Parameters.AddWithValue("@idEquipo", equipo.IdEquipo);

                int filasAfectadas = cn.ejecutanonquery();
                if (filasAfectadas > 0)
                {
                    respuesta = true;
                }

                cn.desconectar();
            }

            return respuesta;
        }

        public bool EliminarEquipo(int idEquipo)
        {
            bool respuesta = false;
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command("DELETE FROM equipos WHERE id_equipo = @idEquipo");
                cmd.Parameters.AddWithValue("@idEquipo", idEquipo);

                int filasAfectadas = cn.ejecutanonquery();
                if (filasAfectadas > 0)
                {
                    respuesta = true;
                }

                cn.desconectar();
            }

            return respuesta;
        }

    } // Fin class
}

using Biblioteca1_Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2_Datos
{
    public class ClienteDAL
    {
        // Inserta un nuevo cliente. Regresa cuántos renglones se afectaron (1 = exito)
        public int Insertar(Cliente c)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                // Comando INSERT con parámetros, para evitar inyección SQL
                var cmd = cn.construye_command(
                    "INSERT INTO clientes (nombre, apPaterno, apMaterno, num_telefono, correo) " +
                    "VALUES (@nombre, @apPaterno, @apMaterno, @telefono, @correo)");

                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@apPaterno", c.ApPaterno);
                cmd.Parameters.AddWithValue("@apMaterno", (object)c.ApMaterno ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", (object)c.NumTelefono ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@correo", (object)c.Correo ?? DBNull.Value);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }

        // Regresa la lista completa de clientes, leyendo con un DataReader
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader("SELECT id_cliente, nombre, apPaterno, apMaterno, num_telefono, correo FROM clientes");
                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Cliente c = new Cliente();
                        c.IdCliente = dr.GetInt32("id_cliente");
                        c.Nombre = dr.GetString("nombre");
                        c.ApPaterno = dr.GetString("apPaterno");
                        c.ApMaterno = dr.IsDBNull(dr.GetOrdinal("apMaterno")) ? "" : dr.GetString("apMaterno");
                        c.NumTelefono = dr.IsDBNull(dr.GetOrdinal("num_telefono")) ? "" : dr.GetString("num_telefono");
                        c.Correo = dr.IsDBNull(dr.GetOrdinal("correo")) ? "" : dr.GetString("correo");
                        lista.Add(c);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

        // Actualiza los datos de un cliente ya existente (se busca por IdCliente)
        public int Actualizar(Cliente c)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "UPDATE clientes SET nombre=@nombre, apPaterno=@apPaterno, apMaterno=@apMaterno, " +
                    "num_telefono=@telefono, correo=@correo WHERE id_cliente=@id");

                cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                cmd.Parameters.AddWithValue("@apPaterno", c.ApPaterno);
                cmd.Parameters.AddWithValue("@apMaterno", (object)c.ApMaterno ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", (object)c.NumTelefono ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@correo", (object)c.Correo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@id", c.IdCliente);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }

        // Elimina un cliente por su Id
        // ¡si el cliente ya tiene equipos registrados, la Foreign Key va a rechazar el borrado!
        public int Eliminar(int idCliente)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command("DELETE FROM clientes WHERE id_cliente=@id");
                cmd.Parameters.AddWithValue("@id", idCliente);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }
    } // Fin class
}

using MySql.Data.MySqlClient;
using Biblioteca1_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2_Datos
{
    internal class RefaccionDAL
    {
        // Inserta una nueva refacción en el inventario
        public int Insertar(Refaccion r)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "INSERT INTO refacciones (nombre, precio_unitario, cant_disponible) " +
                    "VALUES (@nombre, @precio, @cantidad)");

                cmd.Parameters.AddWithValue("@nombre", r.Nombre);
                cmd.Parameters.AddWithValue("@precio", r.PrecioUnitario);
                cmd.Parameters.AddWithValue("@cantidad", r.CantDisponible);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }

        // Regresa todo el catálogo/stock de refacciones
        public List<Refaccion> Listar()
        {
            List<Refaccion> lista = new List<Refaccion>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader("SELECT id_refaccion, nombre, precio_unitario, cant_disponible FROM refacciones");
                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Refaccion r = new Refaccion();
                        r.IdRefaccion = dr.GetInt32("id_refaccion");
                        r.Nombre = dr.GetString("nombre");
                        r.PrecioUnitario = dr.GetDecimal("precio_unitario");
                        r.CantDisponible = dr.GetInt32("cant_disponible");
                        lista.Add(r);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

        // Actualiza el stock disponible de una refacción (se usa al editar o al descontar
        // piezas cuando se agregan a una orden de servicio)
        public int ActualizarStock(int idRefaccion, int nuevaCantidad)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "UPDATE refacciones SET cant_disponible=@cantidad WHERE id_refaccion=@id");

                cmd.Parameters.AddWithValue("@cantidad", nuevaCantidad);
                cmd.Parameters.AddWithValue("@id", idRefaccion);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }

        // Elimina una pieza del catálogo
        public int Eliminar(int idRefaccion)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command("DELETE FROM refacciones WHERE id_refaccion=@id");
                cmd.Parameters.AddWithValue("@id", idRefaccion);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }
    } // Fin class
}

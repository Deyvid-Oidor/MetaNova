using Biblioteca1_Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2_Datos
{
    internal class ServicioDetalleDAL
    {
        // Inserta una refacción usada dentro de una orden de servicio
        public int Insertar(ServicioDetalle d)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "INSERT INTO servicio_detalle (id_servicio, id_refaccion, cantidad, precio_unitario) " +
                    "VALUES (@idServicio, @idRefaccion, @cantidad, @precio)");

                cmd.Parameters.AddWithValue("@idServicio", d.IdServicio);
                cmd.Parameters.AddWithValue("@idRefaccion", d.IdRefaccion);
                cmd.Parameters.AddWithValue("@cantidad", d.Cantidad);
                cmd.Parameters.AddWithValue("@precio", d.PrecioUnitario);

                afectados = cn.ejecutanonquery();
                cn.desconectar();
            }
            return afectados;
        }

        // Regresa las refacciones que se usaron en una orden de servicio en particular
        // (se usa para llenar la tabla de "Refacciones a Utilizar" en la pantalla Nueva Orden)
        public List<ServicioDetalle> ListarPorServicio(int idServicio)
        {
            List<ServicioDetalle> lista = new List<ServicioDetalle>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader(
                    "SELECT sd.id_detalle, sd.id_servicio, sd.id_refaccion, sd.cantidad, sd.precio_unitario, r.nombre " +
                    "FROM servicio_detalle sd " +
                    "INNER JOIN refacciones r ON sd.id_refaccion = r.id_refaccion " +
                    "WHERE sd.id_servicio = " + idServicio);

                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        ServicioDetalle d = new ServicioDetalle();
                        d.IdDetalle = dr.GetInt32("id_detalle");
                        d.IdServicio = dr.GetInt32("id_servicio");
                        d.IdRefaccion = dr.GetInt32("id_refaccion");
                        d.Cantidad = dr.GetInt32("cantidad");
                        d.PrecioUnitario = dr.GetDecimal("precio_unitario");
                        d.NombreRefaccion = dr.GetString("nombre");
                        lista.Add(d);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

    } // Fin class
}

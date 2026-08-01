using Biblioteca1_Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2_Datos
{
    public class ServicioDAL
    {
        // Inserta una nueva orden de servicio y regresa el id_servicio que le tocó
        // (usamos LAST_INSERT_ID() para saber el id recién generado, ya que luego
        // se necesita para insertar el detalle con las refacciones usadas)
        public int Insertar(Servicio s)
        {
            Conexion cn = new Conexion();
            int idGenerado = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "INSERT INTO servicios (id_equipo, id_TipoServicio, id_usuario, id_Estado_Equipo, " +
                    "fecha_ingreso, fecha_entrega, costo_mano_obra) " +
                    "VALUES (@idEquipo, @idTipo, @idUsuario, @idEstado, @fechaIngreso, @fechaEntrega, @costo); " +
                    "SELECT LAST_INSERT_ID();");

                cmd.Parameters.AddWithValue("@idEquipo", s.IdEquipo);
                cmd.Parameters.AddWithValue("@idTipo", s.IdTipoServicio);
                cmd.Parameters.AddWithValue("@idUsuario", s.IdUsuario);
                cmd.Parameters.AddWithValue("@idEstado", s.IdEstadoEquipo);
                cmd.Parameters.AddWithValue("@fechaIngreso", s.FechaIngreso);
                cmd.Parameters.AddWithValue("@fechaEntrega", (object)s.FechaEntrega ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@costo", s.CostoManoObra);

                // Aquí usamos ExecuteScalar directo (en vez de ejecutanonquery) porque
                // necesitamos que nos regrese el id, no solo el número de renglones afectados
                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                    idGenerado = System.Convert.ToInt32(resultado);

                cn.desconectar();
            }
            return idGenerado;
        }

        // Regresa el listado general de órdenes, ya con los datos "amigables" para mostrar
        // en la pantalla de Control y Seguimiento de Servicios (cliente, tipo, estado, fecha)
        public List<Servicio> Listar()
        {
            List<Servicio> lista = new List<Servicio>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader(
                    "SELECT s.id_servicio, s.id_equipo, s.id_TipoServicio, s.id_usuario, s.id_Estado_Equipo, " +
                    "s.fecha_ingreso, s.fecha_entrega, s.costo_mano_obra, " +
                    "c.nombre AS nombre_cliente, t.descripcion, es.nombre_estado " +
                    "FROM servicios s " +
                    "INNER JOIN equipos e ON s.id_equipo = e.id_equipo " +
                    "INNER JOIN clientes c ON e.id_cliente = c.id_cliente " +
                    "INNER JOIN tipo_servicio t ON s.id_TipoServicio = t.id_TipoServicio " +
                    "INNER JOIN estado es ON s.id_Estado_Equipo = es.id_Estado_Equipo");

                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Servicio s = new Servicio();
                        s.IdServicio = dr.GetInt32("id_servicio");
                        s.IdEquipo = dr.GetInt32("id_equipo");
                        s.IdTipoServicio = dr.GetInt32("id_TipoServicio");
                        s.IdUsuario = dr.GetInt32("id_usuario");
                        s.IdEstadoEquipo = dr.GetInt32("id_Estado_Equipo");
                        s.FechaIngreso = dr.GetDateTime("fecha_ingreso");
                        s.FechaEntrega = dr.IsDBNull(dr.GetOrdinal("fecha_entrega")) ? (System.DateTime?)null : dr.GetDateTime("fecha_entrega");
                        s.CostoManoObra = dr.GetDecimal("costo_mano_obra");
                        s.NombreCliente = dr.GetString("nombre_cliente");
                        s.DescripcionTipoServicio = dr.GetString("descripcion");
                        s.NombreEstado = dr.GetString("nombre_estado");
                        lista.Add(s);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }


        public List<Servicio> Buscar(string criterio)
        {
            List<Servicio> lista = new List<Servicio>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                // Consulta SQL con INNER JOIN para traer los datos descriptivos de las otras tablas
                MySqlCommand cmd = cn.construye_command(
                    "SELECT s.id_servicio, s.id_equipo, s.id_TipoServicio, s.id_usuario, s.id_Estado_Equipo, " +
                    "s.fecha_ingreso, s.fecha_entrega, s.costo_mano_obra, " +
                    "c.nombre AS nombre_cliente, t.descripcion, es.nombre_estado " +
                    "FROM servicios s " +
                    "INNER JOIN equipos e ON s.id_equipo = e.id_equipo " +
                    "INNER JOIN clientes c ON e.id_cliente = c.id_cliente " +
                    "INNER JOIN tipo_servicio t ON s.id_TipoServicio = t.id_TipoServicio " +
                    "INNER JOIN estado es ON s.id_Estado_Equipo = es.id_Estado_Equipo " +
                    "WHERE CAST(s.id_servicio AS CHAR) LIKE @criterio OR c.nombre LIKE @criterio " +
                    "ORDER BY s.id_servicio DESC");

                cmd.Parameters.AddWithValue("@criterio", "%" + criterio + "%");

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Servicio s = new Servicio();
                        s.IdServicio = dr.GetInt32("id_servicio");
                        s.IdEquipo = dr.GetInt32("id_equipo");
                        s.IdTipoServicio = dr.GetInt32("id_TipoServicio");
                        s.IdUsuario = dr.GetInt32("id_usuario");
                        s.IdEstadoEquipo = dr.GetInt32("id_Estado_Equipo");
                        s.FechaIngreso = dr.GetDateTime("fecha_ingreso");
                        s.FechaEntrega = dr.IsDBNull(dr.GetOrdinal("fecha_entrega")) ? (System.DateTime?)null : dr.GetDateTime("fecha_entrega");
                        s.CostoManoObra = dr.GetDecimal("costo_mano_obra");

                        // 👇 Aquí asignamos las columnas traídas desde las otras tablas
                        s.NombreCliente = dr.GetString("nombre_cliente");
                        s.DescripcionTipoServicio = dr.GetString("descripcion");
                        s.NombreEstado = dr.GetString("nombre_estado");

                        lista.Add(s);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }


        // Cambia el estado de una orden de servicio (por ejemplo de "En Reparación" a "Reparado")
        public int ActualizarEstado(int idServicio, int idEstadoNuevo)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "UPDATE servicios SET id_Estado_Equipo=@idEstado WHERE id_servicio=@id");

                cmd.Parameters.AddWithValue("@idEstado", idEstadoNuevo);
                cmd.Parameters.AddWithValue("@id", idServicio);

                afectados = cmd.ExecuteNonQuery();
                cn.desconectar();
            }
            return afectados;
        }

        // Regresa el catálogo de estados, para llenar el combo "Cambiar Estado"
        public List<Estado> ListarEstados()
        {
            List<Estado> lista = new List<Estado>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader("SELECT id_Estado_Equipo, nombre_estado FROM estado");
                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Estado e = new Estado();
                        e.IdEstadoEquipo = dr.GetInt32("id_Estado_Equipo");
                        e.NombreEstado = dr.GetString("nombre_estado");
                        lista.Add(e);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

        // Regresa el catálogo de tipos de servicio, para llenar el combo "Tipo de Servicio"
        public List<TipoServicio> ListarTiposServicio()
        {
            List<TipoServicio> lista = new List<TipoServicio>();
            Conexion cn = new Conexion();

            if (cn.conectar())
            {
                cn.construye_reader("SELECT id_TipoServicio, descripcion FROM tipo_servicio");
                MySqlDataReader dr = cn.ejecuta_reader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        TipoServicio t = new TipoServicio();
                        t.IdTipoServicio = dr.GetInt32("id_TipoServicio");
                        t.Descripcion = dr.GetString("descripcion");
                        lista.Add(t);
                    }
                    dr.Close();
                }
                cn.desconectar();
            }
            return lista;
        }

        public int Actualizar(Servicio s)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                MySqlCommand cmd = cn.construye_command(
                    "UPDATE servicios SET " +
                    "id_equipo = @idEquipo, " +
                    "id_TipoServicio = @idTipo, " +
                    "id_usuario = @idUsuario, " +
                    "id_Estado_Equipo = @idEstado, " +
                    "costo_mano_obra = @costo " +
                    "WHERE id_servicio = @idServicio");

                cmd.Parameters.AddWithValue("@idEquipo", s.IdEquipo);
                cmd.Parameters.AddWithValue("@idTipo", s.IdTipoServicio);
                cmd.Parameters.AddWithValue("@idUsuario", s.IdUsuario);
                cmd.Parameters.AddWithValue("@idEstado", s.IdEstadoEquipo);
                cmd.Parameters.AddWithValue("@costo", s.CostoManoObra);
                cmd.Parameters.AddWithValue("@idServicio", s.IdServicio);

                afectados = cmd.ExecuteNonQuery();
                cn.desconectar();
            }
            return afectados;
        }

        public int Eliminar(int idServicio)
        {
            Conexion cn = new Conexion();
            int afectados = 0;

            if (cn.conectar())
            {
                // Primero eliminamos los detalles asociados para no romper la clave foránea (FK)
                MySqlCommand cmdDetalle = cn.construye_command(
                    "DELETE FROM servicio_detalle WHERE id_servicio = @idServicio");
                cmdDetalle.Parameters.AddWithValue("@idServicio", idServicio);
                cmdDetalle.ExecuteNonQuery();

                // Luego eliminamos el registro principal de servicios
                MySqlCommand cmdServicio = cn.construye_command(
                    "DELETE FROM servicios WHERE id_servicio = @idServicio");
                cmdServicio.Parameters.AddWithValue("@idServicio", idServicio);

                afectados = cmdServicio.ExecuteNonQuery();
                cn.desconectar();
            }
            return afectados;
        }


    }
}

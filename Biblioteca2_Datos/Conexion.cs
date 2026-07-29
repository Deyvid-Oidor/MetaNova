using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca2_Datos
{
    // Clase encargada de abrir/cerrar la conexión y armar/ejecutar los comandos SQL.
    internal class Conexion
    {
            private MySqlDataReader leer;          // Lector de datos MySQL
            private MySqlConnection conectr;        // Conexión a la base de datos
            private MySqlCommand cadena_sql;     // Comando SQL que se arma y luego se ejecuta
            private MySqlDataAdapter adaptador;      // Adaptador, para cuando llenamos un DataTable/DataGridView

            // Propiedad de solo lectura del DataReader, por si se necesita afuera
            public MySqlDataReader _Dr
            {
                get { return leer; }
            }

            // Abre la conexión a la base de datos metanova
            // 
            public bool conectar()
            {
                conectr = new MySqlConnection();
                conectr.ConnectionString = "Server=localhost; Database=metanova; Uid=root; Pwd=; Port=3306;SslMode=Disabled;";

                try
                {
                    conectr.Open();
                    return true;
                }
                catch (Exception oEx)
                {
                    MessageBox.Show(oEx.Message);
                    return false; // si no conecta regresamos false para que el DAL no siga
                }
            }

            // Cierra la conexión
            public void desconectar()
            {
                conectr.Close();
            }

            // Arma un SELECT que después se va a ejecutar con ejecuta_reader()
            public void construye_reader(string cadena)
            {
                cadena_sql = new MySqlCommand();
                cadena_sql.Connection = conectr;
                cadena_sql.CommandText = cadena;
                cadena_sql.CommandType = CommandType.Text;
            }

            // Ejecuta el SELECT armado con construye_reader y regresa el DataReader ya abierto
            public MySqlDataReader ejecuta_reader()
            {
                try
                {
                    leer = cadena_sql.ExecuteReader();
                    return leer;
                }
                catch (Exception oEx)
                {
                    MessageBox.Show(oEx.Message);
                    return null;
                }
            }

            // Arma un comando para INSERT, UPDATE o DELETE (se le agregan los parámetros afuera)
            public MySqlCommand construye_command(string cadena)
            {
                cadena_sql = new MySqlCommand(cadena, conectr);
                return cadena_sql;
            }

            // Ejecuta el comando armado con construye_command y regresa cuántos renglones afectó
            public int ejecutanonquery()
            {
                int afectados;
                try
                {
                    afectados = cadena_sql.ExecuteNonQuery();
                    return afectados;
                }
                catch (Exception oEx)
                {
                    MessageBox.Show(oEx.Message);
                    return 0;
                }
            }

            // Arma un adaptador (útil para llenar un DataTable o buscar un solo registro por Id)
            public MySqlDataAdapter construye_adapter(string cadena)
            {
                adaptador = new MySqlDataAdapter(cadena, conectr);
                return adaptador;
            }

        // Extrae la primera fila de la tabla indicada usando el adapter ya armado
        // (se usa por ejemplo en los botones "Seleccionar" para traer un registro por Id)
        public DataRow extrae_registro(MySqlDataAdapter adapter, string nombreTabla)
        {
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, nombreTabla);
                DataTable tabla = ds.Tables[nombreTabla];

                if (tabla.Rows.Count == 0)
                    return null; // no encontró nada con ese Id

                return tabla.Rows[0];
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
                return null;
            }
        }

    } // Fin class 
}

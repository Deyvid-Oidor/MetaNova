using MySql.Data.MySqlClient;
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
            // Validamos que los campos no estén vacíos
            // (Asegúrate de cambiar textBox1, textBox2 y textBox3 por los nombres reales de tus cajas de texto si se llaman diferente)
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor llena los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexionString = "server=localhost;database=metanova;uid=root;pwd=;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    // Consulta para insertar el nuevo usuario en tu base de datos de MySQL
                    string query = "INSERT INTO usuarios (nombre, contrasena, rol) VALUES (@nombre, @contrasena, @rol);";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        // Pasamos los valores de tus cajas de texto a los parámetros de la consulta
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@contrasena", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@rol", textBox3.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos los campos después de guardar con éxito
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpia las cajas de texto (cambia textBox1, textBox2 y textBox3 por los nombres reales de tus cajas de texto si se llaman diferente)
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // Devuelve el cursor a la primera caja de texto
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Validamos que las cajas de texto no estén vacías
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor selecciona un usuario de la tabla o llena los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexionString = "server=localhost;database=metanova;uid=root;pwd=;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    // Consulta para actualizar los datos del usuario (usando el nombre como referencia o ID)
                    string query = "UPDATE usuarios SET contrasena = @contrasena, rol = @rol WHERE nombre = @nombre;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@contrasena", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@rol", textBox3.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos los campos
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Validamos que al menos esté escrito el nombre del usuario a eliminar
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor ingresa o selecciona el nombre del usuario a eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mensaje de confirmación para evitar accidentes
            DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string conexionString = "server=localhost;database=metanova;uid=root;pwd=;";

                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    try
                    {
                        conexion.Open();
                        // Consulta SQL para borrar el registro por nombre
                        string query = "DELETE FROM usuarios WHERE nombre = @nombre;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiamos los campos
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox1.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void CargarTablaUsuarios()
        {
            string conexionString = "server=localhost;database=metanova;uid=root;pwd=1234;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT id, nombre, rol FROM usuarios;"; // Consulta los datos de tu tabla

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Asegúrate de que tu DataGridView se llame dataGridView1 (o cámbialo por su nombre real)
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarTablaUsuarios();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor selecciona un usuario de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conexionString = "server=localhost;database=metanova;uid=root;pwd=;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "UPDATE usuarios SET contrasena = @contrasena, rol = @rol WHERE nombre = @nombre;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@contrasena", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@rol", textBox3.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos y refrescamos la tabla
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox1.Focus();

                    CargarTablaUsuarios(); // Actualiza el DataGridView al instante
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Validamos que haya un usuario seleccionado (cuyo nombre esté en el campo)
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor selecciona un usuario de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mensaje de confirmación para evitar borrados accidentales
            DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string conexionString = "server=localhost;database=metanova;uid=root;pwd=;";

                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    try
                    {
                        conexion.Open();
                        // Consulta SQL para eliminar el usuario buscando por su nombre
                        string query = "DELETE FROM usuarios WHERE nombre = @nombre;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@nombre", textBox1.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiamos los campos y actualizamos la tabla al instante
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox1.Focus();

                        CargarTablaUsuarios(); // Refresca el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}

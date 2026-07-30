using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar referencias
using Biblioteca1_Modelo;
using Biblioteca2_Datos;
using Biblioteca3_Negocio;

namespace MetaNova
{
    public partial class Clientes_Equipos : Form
    {
        public Clientes_Equipos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Equipos_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                ClienteBLL clienteBll = new ClienteBLL();
               

                // Reemplaza dgvClientes por el nombre exacto de tu DataGridView si es diferente
                dvgClientes.DataSource = clienteBll.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Armar el objeto Cliente con los nombres de las cajas de texto
                Cliente cliente = new Cliente()
                {
                    Nombre = txtNombre.Text.Trim(),
                    ApPaterno = txtApPaterno.Text.Trim(),
                    ApMaterno = txtApMaterno.Text.Trim(),
                    NumTelefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim()
                };

                // Instanciar la BLL y guardar
                ClienteBLL clienteBll = new ClienteBLL();
                clienteBll.GuardarCliente(cliente);

                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus(); 
        }

        private void dvgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un cliente en la tabla (DataGridView)
            if (dvgClientes.CurrentRow == null || dvgClientes.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona un cliente de la tabla para poder eliminarlo.", "Aviso");
                return;
            }

            // Obtener el ID del cliente seleccionado
            int idCliente = Convert.ToInt32(dvgClientes.CurrentRow.Cells[0].Value);

            // Confirmar con el usuario antes de borrar
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    //  Llamar a BLL 
                    ClienteBLL clienteBll = new ClienteBLL();
                    clienteBll.EliminarCliente(idCliente);

                    // Refrescar la tabla y limpiar campos
                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar: " + ex.Message, "Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlBuscador_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

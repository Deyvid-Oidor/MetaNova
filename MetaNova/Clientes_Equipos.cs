using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                // Catalogos base
                EquipoBLL equipoBLL = new EquipoBLL();
                cmbMarcas.DataSource = equipoBLL.ListarMarcas();
                cmbMarcas.DisplayMember = "NombreMarca";
                cmbMarcas.ValueMember = "IdMarca";
                cmbMarcas.SelectedIndex = -1;

                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la vista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarClientes()
        {
            try
            {
                ClienteBLL clienteBll = new ClienteBLL();
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
                Cliente cliente = new Cliente()
                {
                    Nombre = txtNombre.Text.Trim(),
                    ApPaterno = txtApPaterno.Text.Trim(),
                    ApMaterno = txtApMaterno.Text.Trim(),
                    NumTelefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim()
                };

                ClienteBLL clienteBll = new ClienteBLL();
                clienteBll.GuardarCliente(cliente);

                MessageBox.Show("Cliente guardado con éxito.", "MetaNova", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLimpiar_Click(sender, e);
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dvgClientes.CurrentRow == null || dvgClientes.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un cliente de la lista primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMarcas.SelectedValue == null || string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Complete los datos requeridos del equipo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Equipo nuevoEquipo = new Equipo
                {
                    IdCliente = Convert.ToInt32(dvgClientes.CurrentRow.Cells[0].Value),
                    IdMarca = Convert.ToInt32(cmbMarcas.SelectedValue),
                    Modelo = txtModelo.Text.Trim(),
                    NumeroSerie = txtNumSerie.Text.Trim()
                };

                EquipoBLL equipoBll = new EquipoBLL();
                equipoBll.GuardarEquipo(nuevoEquipo);

                MessageBox.Show("Equipo asignado con éxito.", "MetaNova", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbMarcas.SelectedIndex = -1;
                txtModelo.Clear();
                txtNumSerie.Clear();

                CargarEquiposDelCliente(nuevoEquipo.IdCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEquiposDelCliente(int idCliente)
        {
            try
            {
                EquipoBLL equipoBll = new EquipoBLL();
                dgvEquipos.AutoGenerateColumns = false;
                dgvEquipos.DataSource = equipoBll.ListarPorCliente(idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar equipos: " + ex.Message);
            }
        }

        private void pnlBuscador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clientes_Equipos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reabrir menu si ya estaba abierto en segundo plano
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu_Principal)
                {
                    frm.Show();
                    return;
                }
            }

            Menu_Principal menu = new Menu_Principal();
            menu.Show();
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dvgClientes.CurrentRow == null || dvgClientes.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona un cliente de la tabla para poder eliminarlo.", "Aviso");
                return;
            }

            int idCliente = Convert.ToInt32(dvgClientes.CurrentRow.Cells[0].Value);

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
                    ClienteBLL clienteBll = new ClienteBLL();
                    clienteBll.EliminarCliente(idCliente);

                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar: " + ex.Message, "Error");
                }
            }
        }

        private void dvgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dvgClientes.CurrentRow != null)
            {
                txtNombre.Text = dvgClientes.CurrentRow.Cells["Nombre"].Value?.ToString();
                txtApPaterno.Text = dvgClientes.CurrentRow.Cells["ApPaterno"].Value?.ToString();
                txtApMaterno.Text = dvgClientes.CurrentRow.Cells["ApMaterno"].Value?.ToString();
                txtTelefono.Text = dvgClientes.CurrentRow.Cells["NumTelefono"].Value?.ToString();
                txtCorreo.Text = dvgClientes.CurrentRow.Cells["Correo"].Value?.ToString();
                int idCliente = Convert.ToInt32(dvgClientes.CurrentRow.Cells[0].Value);
                CargarEquiposDelCliente(idCliente);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dvgClientes.CurrentRow == null || dvgClientes.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un cliente de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validacion basica
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApPaterno.Text))
            {
                MessageBox.Show("Por favor complete al menos el Nombre y Apellido Paterno.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cliente clienteSeleccionado = (Cliente)dvgClientes.CurrentRow.DataBoundItem;

                Cliente clienteAEditar = new Cliente
                {
                    IdCliente = clienteSeleccionado.IdCliente,
                    Nombre = txtNombre.Text.Trim(),
                    ApPaterno = txtApPaterno.Text.Trim(),
                    ApMaterno = txtApMaterno.Text.Trim(),
                    NumTelefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim()
                };

                ClienteBLL clienteBll = new ClienteBLL();
                clienteBll.ActualizarCliente(clienteAEditar);

                MessageBox.Show("Cliente actualizado con éxito.", "MetaNova", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarEquipo_Click(object sender, EventArgs e)
        {
            cmbMarcas.SelectedIndex = -1;
            txtModelo.Clear();
            txtNumSerie.Clear();
            cmbMarcas.Focus();
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEquipos.CurrentRow != null)
            {
                // Mapeo manual por posicion
                string nombreMarca = dgvEquipos.CurrentRow.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(nombreMarca))
                {
                    cmbMarcas.Text = nombreMarca;
                }

                txtModelo.Text = dgvEquipos.CurrentRow.Cells[1].Value?.ToString();
                txtNumSerie.Text = dgvEquipos.CurrentRow.Cells[2].Value?.ToString();
            }
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null || dgvEquipos.CurrentRow.Index < 0)
            {
                MessageBox.Show("Seleccione un equipo de la tabla para poder editarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMarcas.SelectedValue == null || string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Complete la Marca y el Modelo del equipo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Equipo equipoSeleccionado = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;

                Equipo equipoAEditar = new Equipo
                {
                    IdEquipo = equipoSeleccionado.IdEquipo,
                    IdMarca = Convert.ToInt32(cmbMarcas.SelectedValue),
                    Modelo = txtModelo.Text.Trim(),
                    NumeroSerie = txtNumSerie.Text.Trim()
                };

                EquipoBLL equipoBll = new EquipoBLL();
                equipoBll.EditarEquipo(equipoAEditar);

                MessageBox.Show("Equipo actualizado con éxito.", "MetaNova", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int idCliente = Convert.ToInt32(dvgClientes.CurrentRow.Cells[0].Value);
                CargarEquiposDelCliente(idCliente);
                btnLimpiarEquipo_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.CurrentRow == null || dgvEquipos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un equipo de la tabla para poder eliminarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Equipo equipoSeleccionado = (Equipo)dgvEquipos.CurrentRow.DataBoundItem;
            int idEquipo = equipoSeleccionado.IdEquipo;

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que deseas eliminar este equipo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    EquipoBLL equipoBll = new EquipoBLL();
                    equipoBll.EliminarEquipo(idEquipo);

                    MessageBox.Show("Equipo eliminado correctamente.", "MetaNova", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int idCliente = Convert.ToInt32(dvgClientes.CurrentRow.Cells[0].Value);
                    CargarEquiposDelCliente(idCliente);
                    btnLimpiarEquipo_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dvgClientes.CurrentRow != null)
            {
                Cliente clienteSeleccionado = (Cliente)dvgClientes.CurrentRow.DataBoundItem;

                if (clienteSeleccionado != null)
                {
                    txtNombre.Text = clienteSeleccionado.Nombre;
                    txtApPaterno.Text = clienteSeleccionado.ApPaterno;
                    txtApMaterno.Text = clienteSeleccionado.ApMaterno;
                    txtTelefono.Text = clienteSeleccionado.NumTelefono;
                    txtCorreo.Text = clienteSeleccionado.Correo;

                    CargarEquiposDelCliente(clienteSeleccionado.IdCliente);
                }
            }
        }
    }
}
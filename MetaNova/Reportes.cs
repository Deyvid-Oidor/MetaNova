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
    public partial class Reportes : Form
    {
        private int idServicioSeleccionado = 0;

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();
                ServicioBLL servicioBll = new ServicioBLL();

                var resultados = servicioBll.BuscarServicios(criterio);
                dgvReportes.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron órdenes de servicio que coincidan.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if (idServicioSeleccionado <= 0)
            {
                MessageBox.Show("Por favor, selecciona primero una orden de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCambiarEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un estado válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mapeo directo segun indice del combo
            int idEstadoNuevo = cmbCambiarEstado.SelectedIndex + 1;

            ServicioBLL bll = new ServicioBLL();
            bll.ActualizarEstado(idServicioSeleccionado, idEstadoNuevo);

            btnBuscar_Click(sender, e);
        }

        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvReportes.Rows[e.RowIndex];
                if (fila.Cells["IdServicio"].Value != null)
                {
                    idServicioSeleccionado = Convert.ToInt32(fila.Cells["IdServicio"].Value);
                }
            }
        }

        private void dgvReportes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
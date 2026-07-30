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
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            cmbCliente.SelectedIndexChanged -= cmbCliente_SelectedIndexChanged;

            ClienteBLL bll = new ClienteBLL();
            List<Cliente> listaClientes = bll.ListarClientes();

            // Llenamos el ComboBox
            cmbCliente.DataSource = listaClientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "IdCliente";

            // Dejamos deseleccionado
            cmbCliente.SelectedIndex = -1;

            // Volvemos a conectar el evento para las acciones del usuario
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;


            UsuarioBLL usuarioBLL = new UsuarioBLL();
            cmbTecnico.DataSource = usuarioBLL.ListarTecnicos();
            cmbTecnico.DisplayMember = "Nombre";
            cmbTecnico.ValueMember = "IdUsuario";
            cmbTecnico.SelectedIndex = -1;

            cmbTipoServicio.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }


        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedIndex != -1)
            {
                if (int.TryParse(cmbCliente.SelectedValue.ToString(), out int idCliente))
                {
                    // Cargar únicamente los equipos de este cliente
                    CargarEquiposPorCliente(idCliente);
                }
            }
            else
            {
                cmbEquipo.DataSource = null;
            }
        }

        private void CargarEquiposPorCliente(int idCliente)
        {
            EquipoBLL equipoBLL = new EquipoBLL();

            // Obtenemos la lista filtrada por el ID del cliente
            List<Equipo> listaEquipos = equipoBLL.ListarPorCliente(idCliente);

            // Enlazamos al ComboBox de Equipos
            cmbEquipo.DataSource = listaEquipos;

            // Propiedades del modelo Equipo (ajusta "Modelo" si en tu clase se llama diferente, ej: "TipoEquipo" o "Marca")
            cmbEquipo.DisplayMember = "DescripcionCompleta";
            cmbEquipo.ValueMember = "IdEquipo";

            cmbEquipo.SelectedIndex = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlDerecho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCostoManoObra_Click(object sender, EventArgs e)
        {
        }

        private void lbCostoManoObra_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCostoManoObra_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal manoObra = 0;
            decimal.TryParse(txtManoObra.Text, out manoObra);

            // Sumar las refacciones de la tabla 
            decimal totalRefacciones = 0;

            foreach (DataGridViewRow fila in dgvDetalleServicio.Rows)
            {
               
                if (!fila.IsNewRow)
                {
                    
                    var valCantidad = fila.Cells[1].Value;
                    var valUnitario = fila.Cells[2].Value;

                    if (valCantidad != null && valUnitario != null)
                    {
                        decimal unitario = Convert.ToDecimal(valUnitario);
                        int cantidad = Convert.ToInt32(valCantidad);

                        totalRefacciones += (unitario * cantidad);
                    }
                }
            }

          
            decimal totalPagar = totalRefacciones + manoObra;

         
            lbSumaRefacciones.Text = totalRefacciones.ToString("C2");
            lbCostoManoObra.Text = manoObra.ToString("C2");
            lbTotalPagar.Text = totalPagar.ToString("C2");
        }

        private void lbCostoManoObra_Click_2(object sender, EventArgs e)
        {

        }

        private void lbSumaRefacciones_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarRefaccion_Click(object sender, EventArgs e)
        {
            // Agrega una nueva fila a la tabla 
            int index = dgvDetalleServicio.Rows.Add();

            
            dgvDetalleServicio.CurrentCell = dgvDetalleServicio.Rows[index].Cells[0];
            dgvDetalleServicio.BeginEdit(true);
        }

        private void dgvDetalleServicio_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales();
        }

        private void btnQuitarRefaccion_Click(object sender, EventArgs e)
        {
            if (dgvDetalleServicio.CurrentRow != null && !dgvDetalleServicio.CurrentRow.IsNewRow)
            {
               
                dgvDetalleServicio.Rows.Remove(dgvDetalleServicio.CurrentRow);

                CalcularTotales();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una refacción válida de la lista para quitar.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}

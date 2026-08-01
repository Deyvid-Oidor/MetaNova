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
            ServicioBLL servicioBLL = new ServicioBLL();

            // Cargar Clientes
            cmbCliente.SelectedIndexChanged -= cmbCliente_SelectedIndexChanged;

            ClienteBLL bll = new ClienteBLL();
            List<Cliente> listaClientes = bll.ListarClientes();

            // Llenamos el ComboBox
            cmbCliente.DataSource = listaClientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "IdCliente";

            // Dejamos deseleccionado
            cmbCliente.SelectedIndex = -1;

            
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;

            
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            cmbTecnico.DataSource = usuarioBLL.ListarTecnicos();
            cmbTecnico.DisplayMember = "Nombre";
            cmbTecnico.ValueMember = "IdUsuario";
            cmbTecnico.SelectedIndex = -1;

            // Cargar Tipos de Servicio
            cmbTipoServicio.DataSource = servicioBLL.ListarTiposServicio();
            cmbTipoServicio.DisplayMember = "Descripcion";
            cmbTipoServicio.ValueMember = "IdTipoServicio";
            cmbTipoServicio.SelectedIndex = -1;

            // Cargar Estados
            cmbEstado.DataSource = servicioBLL.ListarEstados();
            cmbEstado.DisplayMember = "NombreEstado";
            cmbEstado.ValueMember = "IdEstadoEquipo";
            cmbEstado.SelectedIndex = -1;

            CargarServiciosActivos();
        }

        private void CargarServiciosActivos()
        {
            try
            {
                // Desactivar la creación automática de columnas adicionales
                dgvServiciosActivos.AutoGenerateColumns = false;

                
                if (dgvServiciosActivos.Columns.Contains("Equipo"))
                {
                    dgvServiciosActivos.Columns["Equipo"].DataPropertyName = "IdEquipo"; 
                }

                if (dgvServiciosActivos.Columns.Contains("Estatus"))
                {
                    dgvServiciosActivos.Columns["Estatus"].DataPropertyName = "NombreEstado";
                }

                if (dgvServiciosActivos.Columns.Contains("Total"))
                {
                    dgvServiciosActivos.Columns["Total"].DataPropertyName = "CostoManoObra";
                }

                // Cargar lista y refrescar la fuente de datos
                ServicioBLL servicioBll = new ServicioBLL();
                List<Biblioteca1_Modelo.Servicio> lista = servicioBll.ListarServicios();

                dgvServiciosActivos.DataSource = null;
                dgvServiciosActivos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de servicios: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            // lista filtrada por el ID del cliente
            List<Equipo> listaEquipos = equipoBLL.ListarPorCliente(idCliente);

            
            cmbEquipo.DataSource = listaEquipos;
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
        private void lbCostoManoObra_Click_2(object sender, EventArgs e)
        {

        }
        private void lbSumaRefacciones_Click(object sender, EventArgs e)
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

        private void btnAgregarRefaccion_Click(object sender, EventArgs e)
        {
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
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Servicio_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1 || cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEquipo.SelectedIndex == -1 || cmbEquipo.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un equipo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTipoServicio.SelectedIndex == -1 || cmbTipoServicio.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo de servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTecnico.SelectedIndex == -1 || cmbTecnico.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione el técnico responsable.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEstado.SelectedIndex == -1 || cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione el estado inicial.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string textoManoObra = txtManoObra.Text.Replace("$", "").Trim();
                decimal.TryParse(textoManoObra, out decimal manoObra);

                Biblioteca1_Modelo.Servicio nuevoServicio = new Biblioteca1_Modelo.Servicio
                {
                    IdEquipo = Convert.ToInt32(cmbEquipo.SelectedValue),
                    IdTipoServicio = Convert.ToInt32(cmbTipoServicio.SelectedValue),
                    IdUsuario = Convert.ToInt32(cmbTecnico.SelectedValue),
                    IdEstadoEquipo = Convert.ToInt32(cmbEstado.SelectedValue),
                    CostoManoObra = manoObra,
                    FechaIngreso = DateTime.Now
                };

                List<ServicioDetalle> listaDetalles = new List<ServicioDetalle>();

                foreach (DataGridViewRow fila in dgvDetalleServicio.Rows)
                {
                    if (!fila.IsNewRow && fila.Cells[0].Value != null)
                    {
                        int.TryParse(Convert.ToString(fila.Cells[0].Value), out int idRefaccion);
                        if (idRefaccion <= 0) idRefaccion = 1;

                        int.TryParse(Convert.ToString(fila.Cells[1].Value), out int cantidad);
                        if (cantidad <= 0) cantidad = 1;

                        string textoUnitario = Convert.ToString(fila.Cells[2].Value).Replace("$", "").Trim();
                        decimal.TryParse(textoUnitario, out decimal unitario);

                        ServicioDetalle detalle = new ServicioDetalle
                        {
                            IdRefaccion = idRefaccion,
                            Cantidad = cantidad,
                            PrecioUnitario = unitario
                        };

                        listaDetalles.Add(detalle);
                    }
                }

                ServicioBLL servicioBll = new ServicioBLL();
                int idServicioGenerado = servicioBll.GuardarServicio(nuevoServicio, listaDetalles);

                if (idServicioGenerado > 0)
                {
                    MessageBox.Show("¡Servicio guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    CargarServiciosActivos(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al intentar guardar el servicio: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            cmbCliente.SelectedIndex = -1;
            cmbEquipo.DataSource = null;
            cmbTipoServicio.SelectedIndex = -1;
            cmbTecnico.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtManoObra.Clear();
            dgvDetalleServicio.Rows.Clear();
            CalcularTotales();
        }

        private void dgvServiciosActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvServiciosActivos.Rows[e.RowIndex];

                if (fila.DataBoundItem is Biblioteca1_Modelo.Servicio servicioSel)
                { 

                    cmbEquipo.SelectedValue = servicioSel.IdEquipo;
                    cmbTipoServicio.SelectedValue = servicioSel.IdTipoServicio;
                    cmbTecnico.SelectedValue = servicioSel.IdUsuario;
                    cmbEstado.SelectedValue = servicioSel.IdEstadoEquipo;
                    txtManoObra.Text = servicioSel.CostoManoObra.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvServiciosActivos.CurrentRow == null || dgvServiciosActivos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Por favor, seleccione un servicio de la lista para actualizar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (dgvServiciosActivos.CurrentRow.DataBoundItem is Biblioteca1_Modelo.Servicio servicioSel)
                {
                    string textoManoObra = txtManoObra.Text.Replace("$", "").Trim();
                    decimal.TryParse(textoManoObra, out decimal manoObra);

                    Biblioteca1_Modelo.Servicio servicioActualizado = new Biblioteca1_Modelo.Servicio
                    {
                        IdServicio = servicioSel.IdServicio,
                        IdEquipo = Convert.ToInt32(cmbEquipo.SelectedValue),
                        IdTipoServicio = Convert.ToInt32(cmbTipoServicio.SelectedValue),
                        IdUsuario = Convert.ToInt32(cmbTecnico.SelectedValue),
                        IdEstadoEquipo = Convert.ToInt32(cmbEstado.SelectedValue),
                        CostoManoObra = manoObra
                    };

                    ServicioBLL servicioBll = new ServicioBLL();
                    bool resultado = servicioBll.ActualizarServicio(servicioActualizado);

                    if (resultado)
                    {
                        MessageBox.Show("¡Servicio actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarServiciosActivos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarServicios_Click(object sender, EventArgs e)
        {
            if (dgvServiciosActivos.CurrentRow == null || dgvServiciosActivos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Por favor, seleccione un servicio de la lista para eliminar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvServiciosActivos.CurrentRow.DataBoundItem is Biblioteca1_Modelo.Servicio servicioSel)
            {
                int idServicio = servicioSel.IdServicio;

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar la orden de servicio #" + idServicio + "?\nEsta acción no se puede deshacer.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        ServicioBLL servicioBll = new ServicioBLL();
                        bool resultado = servicioBll.EliminarServicio(idServicio);

                        if (resultado)
                        {
                            MessageBox.Show("Servicio eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            CargarServiciosActivos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar eliminar el servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
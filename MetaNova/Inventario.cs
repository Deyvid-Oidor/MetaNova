// Agregar referencias
using Biblioteca1_Modelo;
using Biblioteca2_Datos;
using Biblioteca3_Negocio;
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
    public partial class Inventario : Form
    {
        private int idRefaccionSeleccionada = 0;

        public Inventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarRefacciones();
        }

        private void CargarRefacciones()
        {
            try
            {
                RefaccionBLL refaccionBll = new RefaccionBLL();
                dgvInventario.DataSource = refaccionBll.ListarRefacciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar refacciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarRefaccion_Click(object sender, EventArgs e)
        {
            try
            {
                Refaccion refaccion = new Refaccion()
                {
                    IdRefaccion = idRefaccionSeleccionada,
                    Nombre = txtNombreRefaccion.Text.Trim(),
                    PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text.Trim()),
                    CantDisponible = Convert.ToInt32(txtCantidadDisponible.Text.Trim())
                };

                RefaccionBLL refaccionBll = new RefaccionBLL();

                // Evaluamos según el ID seleccionado
                if (idRefaccionSeleccionada == 0)
                {
                    // Es un registro nuevo
                    refaccionBll.GuardarRefaccion(refaccion);
                }
                else
                {
                    // Es una edición
                    refaccionBll.ActualizarRefaccion(refaccion);
                }

                CargarRefacciones();
                LimpiarCampos(); // Limpia los campos y resetea idRefaccionSeleccionada a 0
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar refacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarRefaccion_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        
        private void LimpiarCampos()
        {
            txtNombreRefaccion.Clear();
            txtPrecioUnitario.Clear();
            txtCantidadDisponible.Clear();

           
            idRefaccionSeleccionada = 0;

            txtNombreRefaccion.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //  Validar que el usuario haya seleccionado una fila válida
            if (dgvInventario.CurrentRow == null || dgvInventario.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona una refacción de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar el ID en la variable del formulario
            idRefaccionSeleccionada = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);

            // Pasar los valores de las celdas a las cajas de texto 
            txtNombreRefaccion.Text = dgvInventario.CurrentRow.Cells[1].Value?.ToString();
            txtPrecioUnitario.Text = dgvInventario.CurrentRow.Cells[2].Value?.ToString();
            txtCantidadDisponible.Text = dgvInventario.CurrentRow.Cells[3].Value?.ToString();

            
            txtCantidadDisponible.Focus();
        }

        private void btnEliminarPieza_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null || dgvInventario.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona una refacción de la tabla para poder eliminarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Obtener el ID de la refacción seleccionada 
            int idRefaccion = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);

            //  Confirmar con el usuario antes de borrar
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar esta refacción del catálogo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    //  Llamar a BLL para realizar el borrado
                    RefaccionBLL refaccionBll = new RefaccionBLL();
                    refaccionBll.EliminarRefaccion(idRefaccion);

                    //  Refrescar la tabla y resetear los campos
                    CargarRefacciones();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar eliminar la refacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
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




    }
}
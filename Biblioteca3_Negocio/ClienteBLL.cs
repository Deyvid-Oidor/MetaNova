using Biblioteca1_Modelo;
using Biblioteca2_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca3_Negocio
{
    public class ClienteBLL
    {
        // Valida los datos y, si todo está bien, manda a guardar el cliente
        public void GuardarCliente(Cliente c)
        {
            // Validar vacíos: nombre y teléfono son obligatorios
            if (string.IsNullOrWhiteSpace(c.Nombre))
            {
                MessageBox.Show("El nombre del cliente no puede estar vacío.", "Aviso");
                return; // detenemos el proceso, no se manda al DAL
            }

            if (string.IsNullOrWhiteSpace(c.ApPaterno))
            {
                MessageBox.Show("El apellido paterno no puede estar vacío.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(c.NumTelefono))
            {
                MessageBox.Show("El teléfono no puede estar vacío.", "Aviso");
                return;
            }

            // Si pasó las validaciones, ya se puede mandar a la capa de datos
            int afectados = new ClienteDAL().Insertar(c);

            if (afectados > 0)
                MessageBox.Show("Cliente guardado correctamente.", "Aviso");
            else
                MessageBox.Show("No se pudo guardar el cliente.", "Aviso");
        }

        // Misma validación, pero para actualizar un cliente existente
        public void ActualizarCliente(Cliente c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
            {
                MessageBox.Show("El nombre del cliente no puede estar vacío.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(c.ApPaterno))
            {
                MessageBox.Show("El apellido paterno no puede estar vacío.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(c.NumTelefono))
            {
                MessageBox.Show("El teléfono no puede estar vacío.", "Aviso");
                return;
            }

            int afectados = new ClienteDAL().Actualizar(c);

            if (afectados > 0)
                MessageBox.Show("Cliente actualizado correctamente.", "Aviso");
            else
                MessageBox.Show("No se encontró el cliente a actualizar.", "Aviso");
        }

        // No necesita validación, nada más pasa la petición al DAL
        public List<Cliente> ListarClientes()
        {
            return new ClienteDAL().Listar();
        }

        // Elimina un cliente (ojo: truena si el cliente ya tiene equipos registrados, por la FK)
        public void EliminarCliente(int idCliente)
        {
            int afectados = new ClienteDAL().Eliminar(idCliente);

            if (afectados > 0)
                MessageBox.Show("Cliente eliminado.", "Aviso");
            else
                MessageBox.Show("No se pudo eliminar el cliente.", "Aviso");
        }

    } // Fin class 
}

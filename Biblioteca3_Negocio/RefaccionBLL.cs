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
    internal class RefaccionBLL
    {
        // Valida los datos y guarda una refacción nueva en el inventario
        public void GuardarRefaccion(Refaccion r)
        {
            if (string.IsNullOrWhiteSpace(r.Nombre))
            {
                MessageBox.Show("El nombre de la refacción no puede estar vacío.", "Aviso");
                return;
            }

            // Validar precios y números: deben ser mayores a 0
            if (r.PrecioUnitario <= 0)
            {
                MessageBox.Show("El precio unitario debe ser mayor a 0.", "Aviso");
                return;
            }

            if (r.CantDisponible < 0)
            {
                MessageBox.Show("La cantidad disponible no puede ser negativa.", "Aviso");
                return;
            }

            int afectados = new RefaccionDAL().Insertar(r);

            if (afectados > 0)
                MessageBox.Show("Refacción guardada correctamente.", "Aviso");
            else
                MessageBox.Show("No se pudo guardar la refacción.", "Aviso");
        }

        // Regresa todo el catálogo de refacciones (sin validación, solo pasa la petición)
        public List<Refaccion> ListarRefacciones()
        {
            return new RefaccionDAL().Listar();
        }

        // Verifica que haya suficiente stock antes de permitir usar la refacción en un servicio
        // Regresa true si sí alcanza, false si no
        public bool ValidarStockDisponible(int idRefaccion, int cantidadSolicitada)
        {
            if (cantidadSolicitada <= 0)
            {
                MessageBox.Show("La cantidad solicitada debe ser mayor a 0.", "Aviso");
                return false;
            }

            List<Refaccion> lista = new RefaccionDAL().Listar();

            foreach (Refaccion r in lista)
            {
                if (r.IdRefaccion == idRefaccion)
                {
                    if (cantidadSolicitada > r.CantDisponible)
                    {
                        MessageBox.Show("No hay suficiente stock. Disponible: " + r.CantDisponible, "Aviso");
                        return false;
                    }
                    return true; // sí alcanza
                }
            }

            MessageBox.Show("No se encontró la refacción.", "Aviso");
            return false;
        }

        // Descuenta stock de una refacción (se usa después de crear una orden de servicio)
        public void DescontarStock(int idRefaccion, int cantidadUsada)
        {
            List<Refaccion> lista = new RefaccionDAL().Listar();

            foreach (Refaccion r in lista)
            {
                if (r.IdRefaccion == idRefaccion)
                {
                    int nuevoStock = r.CantDisponible - cantidadUsada;
                    if (nuevoStock < 0) nuevoStock = 0; // por seguridad, nunca negativo

                    new RefaccionDAL().ActualizarStock(idRefaccion, nuevoStock);
                    return;
                }
            }
        }

        // Elimina una pieza del catálogo
        public void EliminarRefaccion(int idRefaccion)
        {
            int afectados = new RefaccionDAL().Eliminar(idRefaccion);

            if (afectados > 0)
                MessageBox.Show("Refacción eliminada.", "Aviso");
            else
                MessageBox.Show("No se pudo eliminar la refacción.", "Aviso");
        }
    } // Fin class 
}

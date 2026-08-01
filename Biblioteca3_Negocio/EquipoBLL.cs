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
    public class EquipoBLL
    {
        // Valida los datos y guarda un equipo nuevo asociado a un cliente
        public void GuardarEquipo(Equipo eq)
        {
            // Validar que se haya elegido un cliente (viene de la lista de clientes seleccionada)
            if (eq.IdCliente <= 0)
            {
                MessageBox.Show("Debes seleccionar un cliente antes de agregar el equipo.", "Aviso");
                return;
            }

            // Validar que se haya elegido una marca
            if (eq.IdMarca <= 0)
            {
                MessageBox.Show("Debes seleccionar una marca.", "Aviso");
                return;
            }

            // Validar vacíos: modelo y número de serie son obligatorios
            if (string.IsNullOrWhiteSpace(eq.Modelo))
            {
                MessageBox.Show("El modelo no puede estar vacío.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(eq.NumeroSerie))
            {
                MessageBox.Show("El número de serie no puede estar vacío.", "Aviso");
                return;
            }

            int afectados = new EquipoDAL().Insertar(eq);

            if (afectados > 0)
                MessageBox.Show("Equipo guardado correctamente.", "Aviso");
            else
                MessageBox.Show("No se pudo guardar el equipo.", "Aviso");
        }

        // Regresa los equipos de un cliente en específico (sin validación, solo pasa la petición)
        public List<Equipo> ListarPorCliente(int idCliente)
        {
            return new EquipoDAL().ListarPorCliente(idCliente);
        }

        // Regresa el catálogo de marcas, para llenar el combo "Marca"
        public List<Marca> ListarMarcas()
        {
            return new EquipoDAL().ListarMarcas();
        }

        public bool EditarEquipo(Equipo equipo)
        {
            EquipoDAL equipoDal = new EquipoDAL();
            return equipoDal.EditarEquipo(equipo); 
        }

        public bool EliminarEquipo(int idEquipo)
        {
            EquipoDAL equipoDal = new EquipoDAL();
            return equipoDal.EliminarEquipo(idEquipo);
        }

    } // Fin class
}

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
    public class ServicioBLL
    {
        // Crea una orden de servicio completa: valida, guarda el servicio,
        // guarda cada refacción usada y descuenta el stock correspondiente.
        // Regresa el id_servicio generado, o 0 si algo falló.
        public int GuardarServicio(Servicio s, List<ServicioDetalle> detalles)
        {
            // Validar que el costo de mano de obra no sea negativo
            if (s.CostoManoObra < 0)
            {
                MessageBox.Show("El costo de mano de obra no puede ser negativo.", "Aviso");
                return 0;
            }

            // Validar que se haya elegido equipo, técnico, tipo de servicio y estado
            if (s.IdEquipo <= 0 || s.IdUsuario <= 0 || s.IdTipoServicio <= 0 || s.IdEstadoEquipo <= 0)
            {
                MessageBox.Show("Faltan datos obligatorios de la orden (equipo, técnico, tipo o estado).", "Aviso");
                return 0;
            }

            // Validar stock y cantidades de cada refacción ANTES de guardar cualquier cosa,
            // para no dejar una orden a medias si alguna refacción no alcanza
            RefaccionBLL refaccionBLL = new RefaccionBLL();

            foreach (ServicioDetalle d in detalles)
            {
                if (d.Cantidad <= 0)
                {
                    MessageBox.Show("La cantidad de cada refacción debe ser mayor a 0.", "Aviso");
                    return 0;
                }

                if (!refaccionBLL.ValidarStockDisponible(d.IdRefaccion, d.Cantidad))
                    return 0; // ValidarStockDisponible ya muestra el mensaje de error
            }

            // Ya validado todo, se guarda el servicio y obtenemos su nuevo Id
            int idServicio = new ServicioDAL().Insertar(s);

            if (idServicio == 0)
            {
                MessageBox.Show("No se pudo guardar la orden de servicio.", "Aviso");
                return 0;
            }

            // Se guarda cada detalle (refacción usada) y se descuenta el stock
            ServicioDetalleDAL detalleDAL = new ServicioDetalleDAL();

            foreach (ServicioDetalle d in detalles)
            {
                d.IdServicio = idServicio;
                detalleDAL.Insertar(d);
                refaccionBLL.DescontarStock(d.IdRefaccion, d.Cantidad);
            }

            MessageBox.Show("Orden de servicio #" + idServicio + " guardada correctamente.", "Aviso");
            return idServicio;
        }

        // Regresa el listado de órdenes, sin validación, solo pasa la petición al DAL
        public List<Servicio> ListarServicios()
        {
            return new ServicioDAL().Listar();
        }

        // Cambia el estado de una orden (ej. de "En Reparación" a "Reparado")
        public void ActualizarEstado(int idServicio, int idEstadoNuevo)
        {
            if (idEstadoNuevo <= 0)
            {
                MessageBox.Show("Selecciona un estado válido.", "Aviso");
                return;
            }

            int afectados = new ServicioDAL().ActualizarEstado(idServicio, idEstadoNuevo);

            if (afectados > 0)
                MessageBox.Show("Estado actualizado.", "Aviso");
            else
                MessageBox.Show("No se encontró la orden a actualizar.", "Aviso");
        }

        // Catálogos para llenar combos (sin validación, solo pasan la petición)
        public List<Estado> ListarEstados()
        {
            return new ServicioDAL().ListarEstados();
        }

        public List<TipoServicio> ListarTiposServicio()
        {
            return new ServicioDAL().ListarTiposServicio();
        }

        public List<Servicio> BuscarServicios(string criterio)
        {
            if (string.IsNullOrWhiteSpace(criterio))
            {
                return ListarServicios(); // Si está vacío, usa tu Listar() original
            }

            return new ServicioDAL().Buscar(criterio.Trim());
        }


    } // Fin class
}

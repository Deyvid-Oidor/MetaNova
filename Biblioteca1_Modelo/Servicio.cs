using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca1_Modelo
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public int IdEquipo { get; set; }
        public int IdTipoServicio { get; set; }
        public int IdUsuario { get; set; }
        public int IdEstadoEquipo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public decimal CostoManoObra { get; set; }
        public string NombreCliente { get; set; } // extra, solo para mostrar en pantalla
        public string DescripcionTipoServicio { get; set; } // extra
        public string NombreEstado { get; set; } // extra
    }
}

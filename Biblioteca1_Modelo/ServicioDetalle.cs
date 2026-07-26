using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1_Modelo
{
    public class ServicioDetalle
    {
        public int IdDetalle { get; set; }
        public int IdServicio { get; set; }
        public int IdRefaccion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string NombreRefaccion { get; set; } // extra, solo para mostrar en pantalla
    }
}

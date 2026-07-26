using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1_Modelo
{
    public class Refaccion
    {
        public int IdRefaccion { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int CantDisponible { get; set; }
    }
}

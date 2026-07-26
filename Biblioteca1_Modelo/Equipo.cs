using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1_Modelo
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public int IdCliente { get; set; }
        public int IdMarca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string NombreMarca { get; set; } // extra, solo para mostrar en pantalla
    }
}

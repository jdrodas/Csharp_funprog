using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_ServiciosPublicos
{
    class Servicio
    {
        public string Nombre { get; set; }

        public int Consumo { get; set; }

        public Servicio()
        {
            Nombre = "";
            Consumo = 0;
        }
    }
}

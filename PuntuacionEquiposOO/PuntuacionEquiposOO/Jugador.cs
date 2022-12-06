using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntuacionEquiposOO
{
    internal class Jugador
    {
        //Atributos
        private string nombre;
        private int puntaje;

        //Constructor
        public Jugador()
        {
            nombre = "";
            puntaje = 0;
        }

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }

        }

        //Metodos

    }
}

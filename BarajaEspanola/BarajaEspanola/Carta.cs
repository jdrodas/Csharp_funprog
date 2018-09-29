using System;

namespace BarajaEspanola
{
    class Carta
    {
        //atributos
        private string palo, valor;

        //Constructor de la clase
        public Carta()
        {
            palo = "";
            valor = "";
        }

        // Propiedades para los atributos
        /// <summary>
        /// Obtiene o establece el valor del atributo palo
        /// </summary>
        public string Palo
        {
            get { return palo; }
            set { palo = value; }
        }

        /// <summary>
        /// Obtiene o establece el valor para el atributo valor
        /// </summary>
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}

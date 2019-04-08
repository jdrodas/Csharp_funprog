using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaGalletas
{
    class Galleta
    {
        //atributos
        private string sabor, topping, relleno;

        //Constructor de la clase
        public Galleta()
        {
            sabor = "sin sabor";
            topping = "sin topping";
            relleno = "sin relleno";
        }

        //Métodos
        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }

        public string Topping
        {
            set { topping = value; }
            get { return topping; }
        }

        public string Relleno
        {
            get { return relleno; }
            set { relleno = value; }
        }       
    }
}

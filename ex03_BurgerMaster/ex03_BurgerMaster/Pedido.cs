using System;

namespace ex03_BurgerMaster
{
    class Pedido
    {
        private int codigoLocal;
        private string tipoHamburguesa, tipoBebida, tipoPostre;


        public Pedido()
        {
            codigoLocal = 0;
            tipoHamburguesa = "";
            tipoBebida = "";
            tipoPostre = "";
        }

        public int CodigoLocal
        {
            get { return codigoLocal; }
            set { codigoLocal = value; }
        }

        public string TipoHamburguesa
        {
            get { return tipoHamburguesa; }
            set { tipoHamburguesa = value; }
        }

        public string TipoBebida
        {
            get { return tipoBebida; }
            set { tipoBebida = value; }
        }

        public string TipoPostre
        {
            get { return tipoPostre; }
            set { tipoPostre = value; }
        }
    }
}

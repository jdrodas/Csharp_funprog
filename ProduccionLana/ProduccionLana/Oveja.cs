

namespace ProduccionLana
{
    internal class Oveja
    {
        //Atributos
        private int edad;
        private int peso;
        private int cantidadLana;
        private bool esApta;

        //Constructores
        public Oveja()
        {
            edad = 0;
            peso = 0;
            cantidadLana = 0;
            esApta = false;
        }

        //Propiedades
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public int CantidadLana
        {
            get { return cantidadLana; }
            set { cantidadLana = value; }
        }
        public bool EsApta
        {
            get { return esApta; }
        }

        //Metodos
        public void EvaluaAptitud()
        {
            //una edad entre los 18 y 54 meses, tengan un peso mínimo de 20 kg y una cantidad de lana mínimo de un 1 kg
            if (edad >= 18 && edad <= 54 && peso >= 20 && cantidadLana >= 1)
                esApta = true;
            else
                esApta = false;
        }
    }
}

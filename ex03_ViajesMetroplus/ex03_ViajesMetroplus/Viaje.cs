namespace ex03_ViajesMetroplus
{
    public class Viaje
    {
        //Atributos
        private string ruta;
        private int cantidadPasajeros;

        //Constructor
        public Viaje()
        {
            ruta = "";
            cantidadPasajeros = 0;
        }

        //Propiedades
        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public int CantidadPasajeros
        {
            get { return cantidadPasajeros; }
            set { cantidadPasajeros = value; }
        }
    }
}

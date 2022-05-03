namespace SimRadioOO
{
    public class Radio
    {
        //Atributos
        private float frecuencia;
        private int volumen;
        private bool encendido;

        //Propiedades
        public float Frecuencia { get { return frecuencia; } }

        public int Volumen { get { return volumen; } }

        public bool Encendido { get { return encendido; } }

        //Constructor
        public Radio()
        {
            volumen = 0;
            frecuencia = 88.9f;
            encendido = false;
        }

        //Metodos
        public void SubirVolumen()
        {
            if (volumen != 10)
                volumen++;
        }

        public void BajarVolumen()
        {
            if (volumen != 0)
                volumen--;
        }

        public void SubirFrecuencia()
        {
            if (frecuencia != 107.9f)
                frecuencia++;
            else
                frecuencia = 88.9f;
        }

        public void BajarFrecuencia()
        {
            if (frecuencia != 88.9f)
                frecuencia--;
            else
                frecuencia = 107.9f;
        }

        public void CambiaEncendido()
        {
            if (encendido == true)
                encendido = false;
            else
                encendido = true;
        }
    }
}

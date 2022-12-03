namespace PescaArtesanalOO
{
    internal class Pesca
    {
        //Atributos
        private string especie, metodo;
        private float cantidad;

        //Constructor
        public Pesca()
        {
            especie = "";
            metodo = "";
            cantidad = 0;
        }

        //Propiedades
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public string Metodo
        {
            get { return metodo; }
            set { metodo = value; }
        }

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}

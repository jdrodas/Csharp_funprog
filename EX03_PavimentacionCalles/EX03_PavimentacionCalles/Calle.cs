namespace EX03_PavimentacionCalles
{
    public class Calle
    {
        //Atributos de la clase
        private string tipoDeterioro;
        int longitud;
        float tramoAfectado;

        //Constructor de la clase
        public Calle()
        {
            tipoDeterioro = string.Empty;
            longitud = 0;
            tramoAfectado = 0;
        }

        //Propiedades vinculadas a los atributos
        public string TipoDeterioro
        {
            get { return tipoDeterioro; }
            set { tipoDeterioro = value; }
        }

        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public float TramoAfectado
        {
            get { return tramoAfectado; }
            set { tramoAfectado = value; }
        }
    }
}

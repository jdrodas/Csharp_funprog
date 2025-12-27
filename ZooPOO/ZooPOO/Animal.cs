
namespace ZooPOO
{
    public class Animal
    {
        // Atributos
        private string tipoMedio;
        private string tipoAlimento;
        private int cantidadAlimento;

        //Constructor
        public Animal()
        {
            tipoAlimento = string.Empty;
            tipoMedio = string.Empty;
            cantidadAlimento = 0;
        }

        //Las propiedades
        public string TipoMedio
        {
            get { return tipoMedio; }
            set { tipoMedio = value; }
        }

        public string TipoAlimento
        {
            get { return tipoAlimento; }
            set { tipoAlimento = value; }
        }

        public int CantidadAlimento
        {
            get { return cantidadAlimento; }
            set { cantidadAlimento = value; }
        }
    }
}
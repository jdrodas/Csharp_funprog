
namespace BarajaEspanola
{
    public class Carta
    {
        //Atributos
        private string palo;
        private string valor;

        //Constructor de la clase
        public Carta()
        {
            palo = "";
            valor = "";
        }

        //Propiedades
        public string Palo
        {
            get { return palo; }
            set { palo = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
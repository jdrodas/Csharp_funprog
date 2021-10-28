
namespace ServiciosPublicos
{
    class Servicio
    {
        //Propiedades
        public string Nombre { get; set; }
        public float Consumo { get; set; }

        //Constructor de la clase
        public Servicio()
        {
            Nombre = "";
            Consumo = 0;
        }        
    }
}

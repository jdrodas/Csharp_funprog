namespace MaquinaExpendedoraComida
{
    class Ubicacion
    {
        //Propiedades de la clase
        public string Identificacion { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }

        //constructor de la clase
        public Ubicacion()
        {
            Identificacion = "";
            NombreProducto = "";
            Valor = 0;
            Cantidad = 0;
        }
    }
}
namespace VentaEmpanadas
{
    class Empanada
    {
        //Zona de Propiedades para la clase
        public string Relleno { get; set; }
        public string Masa { get; set; }
        public string Color { get; set; }

        //Constructor de la clase
        public Empanada()
        {
            Relleno = "";
            Masa = "";
            Color = "";
        }
    }
}
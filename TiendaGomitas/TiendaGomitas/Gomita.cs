namespace TiendaGomitas
{
    class Gomita
    {
        //atributos de la clase
        private string color, sabor, forma;

        //el constructor de la clase
        public Gomita()
        {
            color = "";
            sabor = "";
            forma = "";
        }

        //Propiedades de acceso a los atributos

        /// <summary>
        /// Obtiene o establece la forma de la gomita
        /// </summary>
        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }

        /// <summary>
        /// Obtiene o establece el color de la gomita
        /// </summary>
        public string Color
        {
            set { color = value; }
            get { return color; }
        }

        /// <summary>
        /// Obtiene o establece el sabor de la gomita
        /// </summary>
        public string Sabor
        {
            get { return sabor; }
            set { sabor = value; }
        }
    }
}
namespace ComparaReinosOO
{
    class Reino
    {
        //Zona de atributos
        private string rey;
        private int ducados, estados, provincias, puntos;

        //zona de propiedades

        /// <summary>
        /// Obtiene o establece el nombre del rey para el reino
        /// </summary>
        public string Rey
        {
            get { return rey; }
            set { rey = value; }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de ducados del reino
        /// </summary>
        public int Ducados
        {
            get { return ducados; }
            set
            {
                ducados = value;
                ActualizaPuntos();
            }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de estados del reino
        /// </summary>
        public int Estados
        {
            get { return estados; }
            set
            {
                estados = value;
                ActualizaPuntos();
            }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de provincias del reino
        /// </summary>
        public int Provincias
        {
            get { return provincias; }
            set
            {
                provincias = value;
                ActualizaPuntos();
            }
        }

        /// <summary>
        /// Obtiene o establece la cantidad de puntos del reino
        /// </summary>
        public int Puntos
        {
            get { return puntos; }
        }

        //constructor de la clase
        public Reino()
        {
            rey = "";
            ducados = 0;
            estados = 0;
            provincias = 0;
            puntos = 0;
        }

        /// <summary>
        /// Calcula los puntos del reino de acuerdo a la composición
        /// </summary>
        private void ActualizaPuntos()
        {
            /*
                - El numero de estados se multiplica por 2 
                - El numero de ducados se multiplica por 3
                - El numero de provincias se multiplica por 6
            */
            puntos = (estados * 2) + (ducados * 3) + (provincias * 6);
        }

        /// <summary>
        /// Presenta del resumen de información del reino
        /// </summary>
        /// <returns></returns>
        public string ObtieneInfoReino()
        {
            string informacion = $"Rey: {rey}, Total Ducados: {ducados}, " +
                $"Total Estados: {estados}, Total Provincias: {provincias}, " +
                $"Total Puntos: {puntos}";


            return informacion;
        }
    }
}
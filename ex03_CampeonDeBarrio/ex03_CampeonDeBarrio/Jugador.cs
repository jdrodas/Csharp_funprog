namespace ex03_CampeonDeBarrio
{
    public class Jugador
    {
        //Atributos

        private string nombre;
        private int campañas, puntos; 
        private float promedio;

        //Propiedades

        /// <summary>
        /// Obtiene o establece el nombre del jugador
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece el valor de las campañas
        /// </summary>
        public int Campañas
        {
            get { return campañas; }
            set
            {
                campañas = value;
                CalculaPromedio();
            }
        }

        /// <summary>
        /// Obtiene o establece el valor de los puntos
        /// </summary>
        public int Puntos
        {
            get { return puntos; }
            set
            {
                puntos = value;
                CalculaPromedio();
            }
        }

        /// <summary>
        /// Obtiene el valor del promedio
        /// </summary>
        public float Promedio
        {
            get { return promedio; }
        }

        //Constructor de la clase
        public Jugador()
        {
            nombre = "";
            campañas = 0;
            puntos = 0;
            promedio = 0;
        }

        //Metodos

        /// <summary>
        /// Calcula el promedio de puntos por campaña para el jugador
        /// </summary>
        private void CalculaPromedio()
        {
            //Si hay cantidad de campañas, se calcula el promedio
            if (campañas != 0)
                promedio = (float)puntos / campañas;
            else
                promedio = 0;
        }

        /// <summary>
        /// Devuelve información del jugador
        /// </summary>
        /// <returns>cadena de caracteres con la información del jugador</returns>
        public string InfoJugador()
        {
            string informacion = $"Nombre: {nombre}, campañas: {campañas}, puntos: {puntos} con promedio: {promedio.ToString("0.00")}";
            return informacion;
        }
    }
}

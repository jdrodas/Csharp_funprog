namespace MaquinaExpendedoraComida
{
    class MaquinaVenta
    {
        public int ValorVendido { get; set; }
        public int CantidadVentas { get; set; }
        public Ubicacion[] LasUbicaciones { get; set; }
        public MaquinaVenta()
        {
            ValorVendido = 0;
            CantidadVentas = 0;
            LasUbicaciones = new Ubicacion[1]; // Inicializamos con una ubicación

            InicializaUbicaciones();
        }

        /// <summary>
        /// Función que inicializa cada posición de la máquina de venta
        /// </summary>
        private void InicializaUbicaciones()
        {
            LasUbicaciones = new Ubicacion[60];
            string[] letrasIdentificacion = ["A", "B", "C", "D", "E", "F"];

            string valorIdentificacion;
            int ubicacionActual = 0;

            while (ubicacionActual < LasUbicaciones.Length)
            {
                for (int j = 0; j < letrasIdentificacion.Length; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        //Obtiene la combinación letra-Numero que se utilizará para la identificacion
                        valorIdentificacion = letrasIdentificacion[j] + k;

                        //Inicializamos cada posición con los valores predeterminados
                        LasUbicaciones[ubicacionActual] = new Ubicacion
                        {
                            Identificacion = valorIdentificacion,
                            NombreProducto = "",
                            Cantidad = 0,
                            Valor = 0
                        };

                        //Aqui cambiamos a la ubicación siguiente
                        ubicacionActual++;
                    }
                }
            }
        }

        /// <summary>
        /// Valida si la ubicación existe en la máquina expendedora
        /// </summary>
        /// <param name="datoIdUbicacion">Identificación de la ubicación</param>
        /// <returns></returns>
        public bool ValidaUbicacion(string datoIdUbicacion)
        {
            bool resultado = false;

            //recorremos el arreglo de ubicaciones y buscamos la posición que tiene ese ID
            for (int i = 0; i < LasUbicaciones.Length; i++)
                if (LasUbicaciones[i].Identificacion == datoIdUbicacion)
                    resultado = true;

            return resultado;
        }

        /// <summary>
        /// Obtiene el indice en el arreglo de ubicaciones
        /// </summary>
        /// <param name="datoIdUbicacion">ID Ubicación</param>
        /// <returns></returns>
        public int ObtieneIndiceUbicacion(string datoIdUbicacion)
        {
            //Si el indice tiene valor -1, la ubicación no se encontró
            int indice = -1;

            //recorremos el arreglo de ubicaciones y buscamos la posición que tiene ese ID
            for (int i = 0; i < LasUbicaciones.Length; i++)
                if (LasUbicaciones[i].Identificacion == datoIdUbicacion)
                    indice = i;

            return indice;
        }

        /// <summary>
        /// Realiza el proceso de venta del producto en la ubicación solicitada, si hay cantidad disponible
        /// </summary>
        /// <param name="datoIdUbicacion">ID Ubicación</param>
        public void RealizarVenta(string datoIdUbicacion)
        {
            int indiceBuscado = ObtieneIndiceUbicacion(datoIdUbicacion);

            //Si hay cantidad disponible, se realiza la venta
            if (LasUbicaciones[indiceBuscado].Cantidad > 0)
            {
                LasUbicaciones[indiceBuscado].Cantidad--;
                ValorVendido += LasUbicaciones[indiceBuscado].Valor;
                CantidadVentas++;
            }
        }
    }
}
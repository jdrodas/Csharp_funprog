namespace OrdenaNumeros
{
    public class LogicaJuego
    {
        private int[,] matrizValores;
        private int posicionFila, posicionColumna;

        public int[,] MatrizValores
        {
            get { return matrizValores; }
            set { matrizValores = value; }
        }

        public int PosicionFila
        {
            get { return posicionFila; }
            set { posicionFila = value; }
        }

        public int PosicionColumna
        {
            get { return posicionColumna; }
            set { posicionColumna = value; }
        }

        public LogicaJuego()
        {
            posicionFila = 0;
            posicionColumna = 0;
            matrizValores = new int[4, 4];
        }

        /// <summary>
        /// Inicializa la matriz de valores, asignando los numeros a organizar
        /// </summary>
        public void InicializaMatrizValores()
        {
            int valor = 0;

            //Inicialmente se asignan los números del 0 al 15 en toda la matriz
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    matrizValores[i, j] = valor;
                    valor++;
                }

            //Luego, procedemos a cambiar los valores de posición de manera aleatoria
            Random aleatorio = new Random();
            int posicionHorizontal, posicionVertical, valorTemporal;

            //Aqui desordenamos la matriz, calculando posiciones horizontales y
            //verticales dentro de la matriz
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    valorTemporal = matrizValores[i, j];
                    posicionHorizontal = aleatorio.Next(4);
                    posicionVertical = aleatorio.Next(4);

                    matrizValores[i, j] = matrizValores[posicionHorizontal, posicionVertical];
                    matrizValores[posicionHorizontal, posicionVertical] = valorTemporal;
                }
        }


        /// <summary>
        /// Evalua si la posición presionada está adjacente al espacio disponible para usar
        /// </summary>
        public void EvaluaPosicion()
        {
            int valorTemporal = 0;

            //Validamos el valor superior a donde presionamos si está el cero
            if (posicionFila > 0)
            {
                if (matrizValores[posicionFila - 1, posicionColumna] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila - 1, posicionColumna] = valorTemporal;
                }
            }

            //Validamos el valor inferior a donde presionamos si está el cero
            if (posicionFila < 3)
            {
                if (matrizValores[posicionFila + 1, posicionColumna] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila + 1, posicionColumna] = valorTemporal;
                }
            }

            //Validamos el valor izquierdo a donde presionamos si está el cero
            if (posicionColumna > 0)
            {
                if (matrizValores[posicionFila, posicionColumna - 1] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila, posicionColumna - 1] = valorTemporal;
                }
            }

            //Validamos el valor derecho a donde presionamos si está el cero
            if (posicionColumna < 3)
            {
                if (matrizValores[posicionFila, posicionColumna + 1] == 0)
                {
                    valorTemporal = matrizValores[posicionFila, posicionColumna];
                    matrizValores[posicionFila, posicionColumna] = 0;
                    matrizValores[posicionFila, posicionColumna + 1] = valorTemporal;
                }
            }
        }
    }
}

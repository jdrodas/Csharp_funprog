/*
Programa:       ArreglosEdadCaminar
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Un pediatra está realizando un estudio para identificar cual es la edad en meses a partir de la
cual los niños comienzan a caminar. Para ello recopila datos de 100 niños identificando que sus 
momentos de caminar están entre los 9 y 18 meses. Requiere conocer la moda, mediana y la media 
de estos valores.

Realice un programa en C# que genere un arreglo de 100 valores numéricos enteros aleatorios en 
el rango [9;18].  Para cada una de las variables estadísticas, implemente una función que reciba 
como parámetro el arreglo y devuelva el valor requerido.

El programa al final visualizará el contenido del arreglo 20 valores por línea, así como los valores 
de las variables solicitadas
*/


namespace ArreglosEdadCaminar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para buscar moda, mediana y media de valores numéricos");
            Console.WriteLine("son 100 valores correspondientes a la edad de caminar entre 9 y 18 meses");

            //La variable con la que generaremos los valores aleatorios
            Random aleatorio = new();

            int[] arregloEdades = new int[100];

            //Inicializamos el arreglo
            for (int i = 0; i < arregloEdades.Length; i++)
                arregloEdades[i] = aleatorio.Next(8, 18) + 1; //Valores enteros entre 9 y 18

            //Aqui visualizamos los resultados
            Console.WriteLine("\nLas siguientes son las edades generadas aleatoriamente:");

            for (int i = 0; i < arregloEdades.Length; i++)
            {
                Console.Write(arregloEdades[i] + "\t");

                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }

            //Aqui calculamos las variables estadísticas
            float media = CalculaMedia(arregloEdades);
            float mediana = CalculaMediana(arregloEdades);
            int[] moda = CalculaModa(arregloEdades);

            Console.WriteLine($"\nLa media de las edades para caminar es {media}");
            Console.WriteLine($"La mediana de las edades para caminar es {mediana}");
            Console.WriteLine($"Se encontraron {moda.Length} valor(es) como la moda del conjunto de datos");
            for (int i = 0; i < moda.Length; i++)
                Console.WriteLine(moda[i]);

        }

        /// <summary>
        /// Función para calcular la mediana de un arreglo de valores
        /// </summary>
        /// <param name="arregloValores">Arreglo con los valores</param>
        /// <returns>el valor encontrado como mediana</returns>
        static float CalculaMediana(int[] arregloValores)
        {
            //El arreglo debe estar ordenado
            Array.Sort(arregloValores);

            //Como es par la cantidad de valores, se promedian los valores de la mitad, de 100 son el 50 y 51
            float mediana = (float)(arregloValores[49] + arregloValores[50]) / 2;
            return mediana;
        }

        /// <summary>
        /// Función para calcular la moda (valor o valores más frecuentes) de un arreglo de valores
        /// </summary>
        /// <param name="arregloValores">Arreglo con los valores</param>
        /// <returns>Arreglo con los valores más frecuentes</returns>
        static int[] CalculaModa(int[] arregloValores)
        {
            //Aqui declaramos los arreglos que contarán los valores
            int[] referenciaValores = new int[10];
            int[] totalesValores = new int[10];

            //Y lo inicializamos con los valores base
            for (int i = 0; i < referenciaValores.Length; i++)
            {
                referenciaValores[i] = i + 9; // desde 9 hasta 18
                totalesValores[i] = 0;
            }

            //Aqui totalizamos
            for (int i = 0; i < arregloValores.Length; i++)
                for (int j = 0; j < referenciaValores.Length; j++)
                    if (arregloValores[i] == referenciaValores[j])
                        totalesValores[j]++;


            //Identificamos la frecuencia mayor
            int mayor = totalesValores[0];
            for (int i = 1; i < totalesValores.Length; i++)
                if (totalesValores[i] > mayor)
                    mayor = totalesValores[i];

            //Aqui identificamos cuantos tienen esa frecuencia
            int cantidadMayores = 0;
            for (int i = 0; i < totalesValores.Length; i++)
                if (totalesValores[i] == mayor)
                    cantidadMayores++;

            //Finalmente obtenemos quienes son los que tienen la frecuencia mayor
            int[] valoresModa = new int[cantidadMayores];
            int posicion = 0;

            for (int i = 0; i < totalesValores.Length; i++)
            {
                if (totalesValores[i] == mayor)
                {
                    valoresModa[posicion] = referenciaValores[i];
                    posicion++;
                }
            }

            return valoresModa;
        }

        /// <summary>
        /// Función para calcular la media (promedio) de un arreglo de valores
        /// </summary>
        /// <param name="arregloValores">Arreglo con los valores</param>
        /// <returns>Media de los valores contenidos en el arreglo</returns>
        static float CalculaMedia(int[] arregloValores)
        {
            float media = 0f;

            for (int i = 0; i < arregloValores.Length; i++)
                media += arregloValores[i];

            media /= arregloValores.Length;
            return media;
        }
    }
}
/*
Programa:       ArregloPrimos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado:
----------
Realice un programa en C# que genere los números primos menores que 100 y 
los almacene en un arreglo. El programa debe implementar una función que 
reciba el arreglo como parámetro y lo visualice en consola 5 elementos por 
línea, separados entre sí por un tabulador.
*/

namespace ArregloPrimos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para encontrar los números primos menores que 100");

            int totalPrimos = CuentaPrimos(100);
            int[] arregloPrimos = ObtienePrimos(100, totalPrimos);

            Console.WriteLine($"\nEntre 1 y 100 hay {totalPrimos} números primos:");
            VisualizaPrimos(arregloPrimos);
        }

        /// <summary>
        /// Función para visualizar el arreglo de primos, 5 elementos por línea
        /// </summary>
        /// <param name="arreglo">Arreglo de valores</param>
        static void VisualizaPrimos(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + "\t");

                //Si es múltiplo de 5, hacemos salto de línea
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
        }

        /// <summary>
        /// Función para obtener en un arreglo los números primos hasta un limite
        /// </summary>
        /// <param name="limite">El número límite</param>
        /// <param name="totalElementos">El tamaño del arreglo</param>
        /// <returns>El arreglo con los primos encontrados</returns>
        static int[] ObtienePrimos(int limite, int totalElementos)
        {
            //Declaramos el arreglo con la cantidad de primos que hay hasta el límite
            int[] primos = new int[totalElementos];

            //aqui llenamos el arreglo
            int posicion = 0;
            int totalDivisores, divisor;

            for (int i = 1; i < limite; i++)
            {
                totalDivisores = 0;
                divisor = 1;

                while (totalDivisores <= 2 && divisor <= i)
                {
                    if (i % divisor == 0)
                        totalDivisores++;

                    divisor++;
                }

                //Primos encontrados, se almacenan en el arreglo
                if (totalDivisores == 2)
                {
                    primos[posicion] = i;
                    posicion++;
                }
            }

            return primos;
        }

        /// <summary>
        /// Función para contar cuantos números primos hay hasta un limite especificado
        /// </summary>
        /// <param name="limite">Número límite para encontrar los números primos</param>
        /// <returns>TotalPrimosEncontrados</returns>
        static int CuentaPrimos(int limite)
        {
            int totalPrimos = 0;
            int totalDivisores, divisor;

            for (int i = 1; i < limite; i++)
            {
                totalDivisores = 0;
                divisor = 1;

                while (totalDivisores <= 2 && divisor <= i)
                {
                    if (i % divisor == 0)
                        totalDivisores++;

                    divisor++;
                }

                if (totalDivisores == 2)
                    totalPrimos++;
            }

            return totalPrimos;
        }
    }
}
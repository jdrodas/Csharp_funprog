/*
Programa:       ArregloAleatorioLetras
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Enunciado:
----------
Sea el siguiente conjunto de letras las que conforman el abecedario en español:

abcdefghijklmnñopqrstuvwxyz

Realice un programa en C# que:

- genere un arreglo caracteres de 500 posiciones llenado con las letras del abecedario seleccionadas de manera aleatoria. 
- Implemente una función que reciba el arreglo como parámetro y visualice en consola el contenido del arreglo, 25 elementos por línea.
- Implemente una función que reciba en los parámetros el arreglo de letras y el abecedario y visualice en consola el total de veces que aparece cada letra del abecedario en el arreglo de letras.

*/

using System;


namespace ArregloAleatorioLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para generar un arreglo de 500 letras de manera aleatoria");

            //este arreglo será la base para generar los valores aleatorios
            char[] abecedario = "abcdefghijklmnñopqrstuvwxyz".ToCharArray();

            char[] arreglo = new char[500];

            Random aleatorio = new Random();

            //llenamos el arregloAleatorio con valores del arreglo base
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] = abecedario[aleatorio.Next(abecedario.Length)];

            //Aqui visualizamos el contenido del arreglo
            VisualizaArreglo(arreglo);

            //Aqui generamos totales e información sobr el arreglo
            TotalizaLetras(arreglo, abecedario);
        }

        /// <summary>
        /// Función para totalizar y visualizar cuantas hay por cada letra del abecedario
        /// </summary>
        /// <param name="arreglo">El arreglo con las letras aleatorias</param>
        /// <param name="abecedario">el patrón de las letras con las que se genera el arreglo</param>
        static void TotalizaLetras(char[] arreglo, char[] abecedario)
        {
            //aqui declaramos el arreglo de totales
            int[] totalesLetras = new int[abecedario.Length];

            //inicializamos el arreglo de totales
            for (int i = 0; i < totalesLetras.Length; i++)
                totalesLetras[i] = 0;

            //aqui contamos por cada letra
            for (int i = 0; i < arreglo.Length; i++)
                for (int j = 0; j < abecedario.Length; j++)
                    if (arreglo[i] == abecedario[j])
                        totalesLetras[j]++;

            //Finalmente visualizamos los totales
            Console.WriteLine("\nLos totales por letra son los siguientes:");

            for (int i = 0; i < abecedario.Length; i++)
            {
                Console.WriteLine("Letra {0}, total de veces encontrada: {1}",
                    abecedario[i], totalesLetras[i]);
            }

        }

        static void VisualizaArreglo(char[] arreglo)
        {
            //aqui visualizamos las letras en el arreglo
            Console.WriteLine("Las letras en el arreglo son: \n");

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");

                if ((i+1) % 25 == 0) //Colocamos 25 elementos por línea
                    Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}

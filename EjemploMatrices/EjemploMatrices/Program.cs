/*
Programa:       EjemploMatrices
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar el funcionamiento básico del arreglo bidimensional (matriz)

*/

namespace EjemploMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para llenar una matriz de 3x3 con los numeros enteros del 1 al 9\t");

            int i, j, numero = 1;
            int[,] matriz = new int[3, 3];

            //aqui llenamos la matriz i para las filas, j para las columnas
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    matriz[i, j] = numero;
                    numero++;
                }
            }

            //visualizamos la matriz
            Console.WriteLine("La matriz con los números se ve asi:");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

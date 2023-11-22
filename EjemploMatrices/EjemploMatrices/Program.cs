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
        static void Main()
        {
            Console.WriteLine("Programa para llenar una matriz de 4x3 \ncon numeros aleatorios entre 1 y 100\n");

            int filas, columnas;
            int[,] matriz = new int[4, 3];

            Console.WriteLine($"La matriz tiene una capacidad de {matriz.Length} elementos");
            Console.WriteLine($"La matriz tiene {matriz.Rank} dimensiones");
            Console.WriteLine($"Tiene {matriz.GetLength(0)} filas y {matriz.GetLength(1)} columnas");

            Random aleatorio = new();

            //aqui llenamos la matriz utilizando los tamaños de cada dimensión
            for (filas = 0; filas < matriz.GetLength(0); filas++)
                for (columnas = 0; columnas < matriz.GetLength(1); columnas++)
                    matriz[filas, columnas] = aleatorio.Next(100) + 1;

            //visualizamos la matriz
            Console.WriteLine("\nEl contenido de la matriz es:\t");

            for (filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (columnas = 0; columnas < matriz.GetLength(1); columnas++)
                    Console.Write($"{matriz[filas, columnas]} \t");

                Console.WriteLine();
            }

            //Que pasa si intercambiamos el orden de los ciclos "for" anidados?
            Console.WriteLine("\n¿Es esta la matriz transpuesta?:\t");
            for (columnas = 0; columnas < matriz.GetLength(1); columnas++)
            {
                for (filas = 0; filas < matriz.GetLength(0); filas++)
                    Console.Write($"{matriz[filas, columnas]} \t");

                Console.WriteLine();
            }
        }
    }
}

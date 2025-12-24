/*
Programa:       CiclosAsteriscos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Generar patrones piramidales con asteriscos en una aplicación de consola
 utilizando ciclos repetitivos. 

*/
namespace CiclosAsteriscos
{
    class Program
    {
        static void Main()
        {
            int cantidadLineas, totalAsteriscos, totalEspacios;

            Console.WriteLine("Programa para generar patrones con asteriscos");

            Console.WriteLine("\nPatrón No. 1 - Ascendente a la izquierda:");
            //aqui implementamos con un ciclo for para recorrer las lineas
            for (cantidadLineas = 1; cantidadLineas <= 10; cantidadLineas++)
            {
                //aqui implementamos con un ciclo for para recorrer los asteriscos
                for (totalAsteriscos = 1; totalAsteriscos <= cantidadLineas; totalAsteriscos++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine("\nPatrón No. 2 - Descendente a la izquierda:");
            //aqui implementamos con un ciclo for para recorrer las lineas
            for (cantidadLineas = 10; cantidadLineas >= 1; cantidadLineas--)
            {
                //aqui implementamos con un ciclo for para recorrer los asteriscos
                for (totalAsteriscos = 1; totalAsteriscos <= cantidadLineas; totalAsteriscos++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine("\nPatrón No. 3 - Descendente a la derecha:");
            //aqui implementamos con un ciclo for para recorrer las lineas
            for (cantidadLineas = 10; cantidadLineas >= 1; cantidadLineas--)
            {
                totalEspacios = 10 - cantidadLineas;
                // un ciclo for para recorrer los espacios
                for (int i = 1; i <= totalEspacios; i++)
                    Console.Write(" ");

                //aqui implementamos con un ciclo for para recorrer los asteriscos
                for (totalAsteriscos = cantidadLineas; totalAsteriscos >= 1; totalAsteriscos--)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.WriteLine("\nPatrón No. 4 - ascendente a la derecha:");
            //aqui implementamos con un ciclo for para recorrer las lineas
            for (cantidadLineas = 1; cantidadLineas <= 10; cantidadLineas++)
            {
                totalEspacios = 10 - cantidadLineas;
                // un ciclo for para recorrer los espacios
                for (int i = 1; i <= totalEspacios; i++)
                    Console.Write(" ");

                //aqui implementamos con un ciclo for para recorrer los asteriscos
                for (totalAsteriscos = cantidadLineas; totalAsteriscos >= 1; totalAsteriscos--)
                    Console.Write("*");

                Console.WriteLine();
            }

        }
    }
}
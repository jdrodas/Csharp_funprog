/*
Programa:       EjemploCiclosControl
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar el funcionamiento de los principales ciclos de control implementando una sumatoria.

Ciclos de control:

- while
- do while
- for

 */

using System;

namespace EjemploCiclosControl
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Elementos importantes de un ciclo de control:
             - Varaible de control con valor inicial que permite ejecutar el ciclo
             - Condición que se evaluará y permitirá ejecutar el ciclo mientras sea TRUE
             - Sentencia de salida que permite que el condicional sea FALSE y termine
            */

            Console.WriteLine("Suma de los numeros naturales hasta un límite especificado\n");

            Console.Write("Ingresa el número límite: ");
            int limite = int.Parse(Console.ReadLine());

            int numero = 1; // variable de control con su valor inicial
            int suma = 0;

            // Implementación utilizando el ciclo while:
            while (numero <= limite)
            {
                suma = suma + numero; // acumulación
                numero = numero + 1; // contador -- sentencia de salida
            }

            Console.WriteLine("\nUsando el ciclo while, la suma de los números naturales hasta {0} es {1}",
                limite,
                suma);

            // Se inicializan las variables para otro ciclo
            suma = 0;       // Se reinicia la acumulación del resultado
            numero = 1;     // Se reinicia la variable de control del ciclo

            //Implementación utilizando el ciclo do - while

            do
            {
                suma += numero;      // otra forma de acumulación
                numero += 1;        //  otra forma de incrementar el contador -- sentencia de salida
            }
            while (numero <= limite);

            Console.WriteLine("\nUsando el ciclo do - while, la suma de los números naturales hasta {0} es {1}",
                limite,
                suma);

            // Se inicializan las variables para otro ciclo
            suma = 0;       // Se reinicia la acumulación del resultado

            //Implementación utilizando el ciclo for
            for (numero = 1; numero <= limite; numero++)
            {
                suma += numero;
            }

            Console.WriteLine("\nUsando el ciclo for, la suma de los números naturales hasta {0} es {1}",
                limite,
                suma);

        }
    }
}

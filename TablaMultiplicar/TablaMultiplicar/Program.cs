/*
Programa:       TablaMultiplicar
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar el funcionamiento de los principales ciclos de control implementando una aplicación
que visualice la tabla de multiplicar de un número natural.

Ciclos de control:

- while
- do while
- for

 */

using System;

namespace TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa que visualiza la tabla de multiplicar de un número\n");

            Console.Write("Ingresa el número: ");
            int numero = int.Parse(Console.ReadLine());

            // Declaramos la variable de control
            int multiplicador = 1;

            // Implementación de la solución con el ciclo While
            Console.WriteLine("\n\nCon el ciclo While, la tabla de multiplicar del número {0}:", numero);

            while (multiplicador <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}",
                    numero,
                    multiplicador,
                    (numero * multiplicador));

                multiplicador++;
            }

            // Reiniciamos el valor de la variable de control para el siguiente ciclo
            multiplicador = 1;

            // Implementación de la solución con el ciclo do - while
            Console.WriteLine("\n\nCon el ciclo do while, la tabla de multiplicar del número {0}:", numero);

            do
            {
                Console.WriteLine("{0} x {1} = {2}",
                    numero,
                    multiplicador,
                    (numero * multiplicador));

                multiplicador++;
            } while (multiplicador <= 10);

            // Implementación de la solución con el ciclo do - while
            Console.WriteLine("\n\nCon el for, la tabla de multiplicar del número {0}:", numero);

            for (multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine("{0} x {1} = {2}", 
                    numero, 
                    multiplicador, 
                    (numero * multiplicador));
            }
        }
    }
}

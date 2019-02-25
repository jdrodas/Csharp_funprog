/*
Programa:       SumaMultiplosDe3y5
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Resolver el ejercicio No. del Proyecto Euler (https://projecteuler.net/problem=1)
- Encontrar la suma de los múltiplos de 3 ó 5 que son inferiores a un límite indicado
- Implementar el control de ingreso de datos con la función TryParse()

 */

using System;

namespace SumaMultiplosDe3y5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para sumar los números que son múltiplos de 3 o 5 inferiores a un límite");

            bool datoCorrecto = false;
            int limite=0, suma = 0;

            while (!datoCorrecto)
            {
                Console.Write("\nIngresa el número límite: ");
                datoCorrecto = int.TryParse(Console.ReadLine(), out limite);

                if (datoCorrecto)
                {
                    Console.WriteLine("\nEl limite ingresado es: {0}", limite);
                    Console.WriteLine("Los números multiplos de 3 o de 5 menores que {0} son", limite);

                    for (int numero = 1; numero < limite; numero++)
                    {
                        if (numero % 3 == 0 || numero % 5 == 0)
                        {
                            Console.WriteLine("Numero encontrado: {0}", numero);
                            suma += numero;
                        }
                    }

                    Console.WriteLine("La suma es {0}", suma);
                }
                else
                {
                    Console.WriteLine("No ingresaste un dato numérico. Intenta nuevamente!");
                }
            }            
        }
    }
}

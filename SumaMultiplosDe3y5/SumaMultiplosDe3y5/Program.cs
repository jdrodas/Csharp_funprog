/*
Programa:       SumaMultiplosDe3y5
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Resolver el ejercicio No. del Proyecto Euler (https://projecteuler.net/problem=1)
- Encontrar la suma de los múltiplos de 3 ó 5 que son inferiores a un límite indicado
- Implementar el control de ingreso de datos con la función TryParse()

 */

namespace SumaMultiplosDe3y5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para sumar los números que son múltiplos de 3 o 5 inferiores a un límite");

            bool datoCorrecto = false;
            uint limite = 0, suma = 0;

            while (!datoCorrecto)
            {
                Console.Write("\nIngresa el número límite: ");
                datoCorrecto = uint.TryParse(Console.ReadLine(), out limite);

                if (datoCorrecto)
                    Console.WriteLine($"\nEl limite ingresado es: {limite}");
                else
                    Console.WriteLine("No ingresaste un dato numérico. Intenta nuevamente!");
            }

            Console.WriteLine($"Los números multiplos de 3 o de 5 menores que {limite} son :");

            // Aqui calculamos la suma de los multiplos de 3 o de 5
            for (uint numero = 1; numero < limite; numero++)
            {
                if (numero % 3 == 0 || numero % 5 == 0)
                {
                    Console.WriteLine($"Numero encontrado: {numero}");
                    suma += numero;
                }
            }

            Console.WriteLine($"La suma es {suma}");
        }
    }
}
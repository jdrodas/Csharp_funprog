/*
Programa:       NumerosPerfectos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Identificar si un numero entero positivo es un numero perfecto.

Un número perfecto es un número natural que es igual a la suma de sus divisores propios 
positivos. Dicho de otra forma, un número perfecto es aquel que es amigo de sí mismo.

https://es.wikipedia.org/wiki/N%C3%BAmero_perfecto

Ejemplos:
6 28 496 8128

*/

namespace NumerosPerfectos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para identificar si un numero entero es perfecto");

            bool esCorrecto = false;
            long numero = 0;

            //Repetimos el proceso hasta que el usuario ingrese un dato válido
            while (esCorrecto == false)
            {
                try
                {
                    Console.Write("Ingresa un numero entero positivo: ");
                    numero = long.Parse(Console.ReadLine()!);

                    //Validamos que sea entero positivo hasta 4 cifras
                    if (numero > 0)
                        esCorrecto = true;
                    else
                        Console.WriteLine("El dato ingresado no es un entero positivo. Intenta nuevamente! \n");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine("Error: " + error.Message + "\n");
                }
            }

            //Aqui buscamos cuales son los divisores propios
            long sumaDivisores = 0;

            for (long divisor = 1; divisor < numero; divisor++)
            {
                //verificamos si es divisor
                if (numero % divisor == 0)
                    sumaDivisores += divisor;
            }

            //Aqui visualizamos el resultado
            if (sumaDivisores == numero)
                Console.WriteLine($"{numero} es un número perfecto. Sus divisores suman igual que el número!");
            else
                Console.WriteLine($"{numero} NO es un número perfecto. Sus divisores suman {sumaDivisores} que es diferente al número!");
        }
    }
}
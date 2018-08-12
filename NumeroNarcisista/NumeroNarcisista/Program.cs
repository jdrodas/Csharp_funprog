/*
Programa:       NumeroNarcisista
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Identificar si un número entero de tres cifras es narcisista

un número narcisista es aquel que es igual a la suma de sus dígitos elevados a la potencia de su número de cifras. 
https://es.wikipedia.org/wiki/N%C3%BAmero_narcisista

Ejemplos : 153 370 371 407

 */

using System;

namespace NumeroNarcisista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para identificar si un numero entero de tres cifras es narcisista\n");

            bool esCorrecto = false;
            int numero = 0;

            //Repetimos el proceso hasta que el usuario ingrese un dato válido
            while (esCorrecto == false)
            {
                try
                {
                    Console.Write("Ingresa un numero entero positivo de 3 cifras: ");
                    numero = int.Parse(Console.ReadLine());

                    //Validamos que sea entero positivo hasta 3 cifras
                    if (numero > 99 && numero < 1000)
                        esCorrecto = true;
                    else
                        Console.WriteLine("El dato ingresado no es un entero positivo de 3 cifras. Intenta nuevamente! \n\n");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente! \n\n");
                }
            }

            //Ya ingresado el número, identificamos sus dígitos
            double unidades, decenas, centenas;

            centenas = Math.Truncate((double)numero / 100);
            decenas = Math.Truncate((double)(numero - (centenas * 100)) / 10);
            unidades = numero - (centenas * 100) - (decenas * 10);

            Console.WriteLine("Numero {0}: Unidades {1}, Decenas {2}, Centenas {3}",
                numero, unidades, decenas, centenas);

            double resultado = Math.Pow(unidades, 3) +
                               Math.Pow(decenas, 3) +
                               Math.Pow(centenas, 3);

            if (resultado == numero)
                Console.WriteLine("El numero es narcisista");
            else
                Console.WriteLine("El número no es narcisista. El resultado es {0}",
                    resultado);

        }
    }
}

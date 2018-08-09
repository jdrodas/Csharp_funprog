/*
Programa:       ClasificaNumeros
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Demostrar la característica específica del ciclo do-while al momento de evaluar la condición. Utilización del concepto de variable "bandera".

 */

using System;

namespace ClasificaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para clasificar numeros enteros en positivos, negativos, pares e imapres\n");

            //aqui declaramos una variable tipo bandera;
            bool quiereContinuar = true;

            int numero, totalClasificados =0;
            string respuesta;

            do
            {
                Console.Write("Ingresa un numero entero: ");
                numero = int.Parse(Console.ReadLine());

                //aqui verificamos si es par o impar
                if ((numero % 2) == 0)
                    Console.WriteLine("{0} es par", numero);
                else
                    Console.WriteLine("{0} es impar", numero);
                
                //aqui verificamos si es positivo o negativo
                if (numero >= 0)
                    Console.WriteLine("{0} es positivo", numero);                
                else
                    Console.WriteLine("{0} es negativo", numero);

                //aqui llevamos registro de números clasificados
                totalClasificados++;

                Console.Write("Desea clasificar otro número? (S/N): ");
                respuesta = Console.ReadLine().ToLower();  // ToLower(): Pasar la cadena a minúscula

                // la condición de salida
                if (respuesta != "s")
                    quiereContinuar = false;
            }
            while (quiereContinuar == true);

            Console.WriteLine("\n\nEl total de números clasificados fue {0}", totalClasificados);
        }
    }
}

/*
Programa:       ValidaBisiesto
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Implemementa una función que valida si un año es bisiesto

 */
using System;

namespace ValidaBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para validar si un año es bisiesto");
            Console.WriteLine("Las condiciones para que sea, son:");
            Console.WriteLine(" - Divisible por 4");
            Console.WriteLine(" - Si termina en 00, que sea divisible por 400\n");

            bool datoCorrecto = false;
            int dato = 0;

            while (datoCorrecto==false)
            {
                try
                {
                    Console.Write("Ingresa un año para evaluar: ");
                    dato = int.Parse(Console.ReadLine());

                    datoCorrecto = true; //Si el dato fue correcto, salimos del ciclo.
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine(elError.Message + "\n");
                }
            }

            Console.WriteLine("Evaluando si {0} es bisiesto...",dato);

            //llamamos la función para evaluar si es bisiesto
            bool esBisiesto = EvaluaBisiesto(dato);

            if (esBisiesto)
                Console.WriteLine("Si, ese año si es bisiesto!");
            else
                Console.WriteLine("No, ese año no es bisiesto!");
        }

        /// <summary>
        /// Evalua si el dato de un año es bisiesto o no
        /// </summary>
        /// <param name="elDato">el número correspondiente al año</param>
        /// <returns>Verdadero si el año es bisiesto</returns>
        static bool EvaluaBisiesto(int elDato)
        {
            bool resultado = false;

            //Preguntar si es divisible por 100 (o sea, terminado en 00)
            if (elDato % 100 == 0)
            {
                if (elDato % 400 == 0)
                    resultado = true;
            }
            else
            {
                if (elDato % 4 == 0)
                    resultado = true;
            }

            return resultado;
        }
    }
}

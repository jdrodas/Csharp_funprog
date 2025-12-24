/*
Programa:       ValidaBisiesto
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Implemementa una función que valida si un año es bisiesto
- Implementa una función que indica si un numero es divisible por otro

*/

namespace ValidaBisiesto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para validar si un año es bisiesto");
            Console.WriteLine("Las condiciones para que sea, son:");
            Console.WriteLine(" - Divisible por 4");
            Console.WriteLine(" - Si termina en 00, que sea divisible por 400\n");

            bool datoCorrecto = false;
            int dato = 0;

            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("Ingresa un año para evaluar: ");
                    dato = int.Parse(Console.ReadLine()!);

                    datoCorrecto = true; //Si el dato fue correcto, salimos del ciclo.
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine(elError.Message + "\n");
                }
            }

            Console.WriteLine("Evaluando si {0} es bisiesto...", dato);

            //llamamos la función para evaluar si es bisiesto
            bool esBisiesto = EvaluaBisiesto(dato);

            if (esBisiesto)
                Console.WriteLine("Si, ese año SI es bisiesto!");
            else
                Console.WriteLine("No, ese año NO es bisiesto!");
        }

        /// <summary>
        /// Evalua si el dato de un año es bisiesto o no
        /// </summary>
        /// <param name="elDato">el número correspondiente al año</param>
        /// <returns>Verdadero si el año es bisiesto</returns>
        static bool EvaluaBisiesto(int elDato)
        {
            bool resultado = false;

            //Paso 1: Validar si es divisible por 4:
            if (EsDivisiblePor(elDato, 4) == true)
            {
                //Paso 2: Validar si es divisible por 100:
                if (EsDivisiblePor(elDato, 100))
                {
                    //Paso 3: Validar si siendo divisible por 100, es divisible por 400
                    if (EsDivisiblePor(elDato, 400))
                        resultado = true;
                }
                else
                    //No es divisible por 100, pero si es divisible por 4, si es bisiesto
                    resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Función que identifica si el divisor genera residuo 0
        /// </summary>
        /// <param name="dividendo">Valor a dividir</param>
        /// <param name="divisor">El divisor</param>
        /// <returns>Respuesta si es divisible</returns>
        static bool EsDivisiblePor(int dividendo, int divisor)
        {
            bool resultado = false;

            if (dividendo % divisor == 0)
                resultado = true;

            return resultado;
        }
    }
}
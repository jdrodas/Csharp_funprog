/*
Programa:       ValidaNumeroPrimo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Demostrar el funcionamiento de una función
- Identificar si un numero entero es primo
*/

namespace ValidaNumeroPrimo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para identificar si un número es primo o no");
            int numero = 0;
            bool datoCorrecto = false;

            // Implementamos la funcionalidad que permite leer un número entero validando
            // que sea positivo
            do
            {
                try
                {
                    Console.Write("Ingresa un numero entero positivo: ");
                    numero = int.Parse(Console.ReadLine()!);

                    if (numero > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("El numero no es positivo. Intenta nuevamente!");

                }
                catch (FormatException error)
                {
                    Console.WriteLine("Dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }
            }
            while (datoCorrecto == false);

            //aqui invocamos la función que indica si es primo
            bool resultado = EsPrimo(numero);

            if (resultado)
                Console.WriteLine("El número es primo!");
            else
                Console.WriteLine("El número NO es primo!");
        }

        /// <summary>
        /// Función que identifica si un número es primo o no
        /// </summary>
        /// <param name="dato">el número a evaluar</param>
        /// <returns>resultado de la evaluación - Verdadero si es primo</returns>
        static bool EsPrimo(int dato)
        {
            bool resultado = false;

            int totalDivisores = 0;
            //aqui implementamos el algoritmo para contar los divisores

            //altamente ineficiente, porque recorre todos los numeros
            //¿Cómo lo mejoras?
            for (int divisor = 1; divisor <= dato; divisor++)
            {
                if (dato % divisor == 0)
                    totalDivisores++;
            }

            if (totalDivisores == 2)
                resultado = true;

            return resultado;
        }
    }
}
/*
Programa:       EjemploFunciones
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Generar un arreglo con valores enteros aleatorios
- Implementar funciones que encuentre los valore menores y mayores del arreglo
- Implementar una función que encuentre las posiciones donde está un valor
- Implementar una función que ordene un arreglo entero utilizando el algortimo burbuja
*/

using System;

namespace EjemploFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar funciones");

            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nAqui se utiliza una función que recibe parámetro pero no devuelve valor");
            VisualizaNumero(numero);

            int otroNumero = MultiplicadoPorDiez(numero);

            Console.WriteLine("\n\nAqui se utiliza una función que recibe parámetro y devuelve un valor");
            Console.WriteLine("El numero multiplicado por 10 es {0}", otroNumero);

            Console.WriteLine("\n\nAqui se utiliza una función que no recibe parámetro y no devuelve un valor");
            MuestrameLaFecha();

            Console.WriteLine("\n\nAqui se utiliza una función que no recibe parámetro y devuelve un valor");
            string hora = ObtieneHora();
            Console.WriteLine("La hora actual es: " + hora);

        }

        /// <summary>
        /// Función que no recibe parametro pero devuelve un valor
        /// </summary>
        /// <returns>la hora actual en formato string</returns>
        static string ObtieneHora()
        {
            string resultado = DateTime.Now.ToLongTimeString();
            return resultado;
        }

        /// <summary>
        /// Función que no recibe parametro y no devuelve valor
        /// </summary>
        static void MuestrameLaFecha()
        {
            string laFecha = DateTime.Now.ToLongDateString();

            Console.WriteLine("La fecha actual: " + laFecha);
        }

        /// <summary>
        /// Función que recibe parametro numérico y devuelve su valor multiplicado x 10
        /// </summary>
        /// <param name="datoNumero">dato numérico entero</param>
        /// <returns>El número multiplicado por 10</returns>
        static int MultiplicadoPorDiez(int datoNumero)
        {
            int resultado = datoNumero * 10;
            return resultado;
        }

        /// <summary>
        /// Función que recibe un parámetro y lo duplica
        /// </summary>
        /// <param name="datoNumero">dato numérico entero</param>
        static void VisualizaNumero(int datoNumero)
        {
            datoNumero *= 2;
            Console.WriteLine("El número duplicado es {0}", datoNumero);
        }
    }
}

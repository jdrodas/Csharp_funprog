/*
Programa:       ValidaRango
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
- Valida si un número ingresado hace parte de un rango definido por otros dos números

 */

namespace ValidaRango
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para validar si un numero entero está en un rango");

            bool datoCorrecto = false;
            int inferior = 0, superior = 0, numero = 0;

            while (datoCorrecto == false)
            {
                try
                {
                    Console.Write("Ingresa el límite inferior del rango: ");
                    inferior = int.Parse(Console.ReadLine()!);

                    Console.Write("Ingresa el límite superior del rango: ");
                    superior = int.Parse(Console.ReadLine()!);

                    Console.Write("Ingresa el número a evaluar: ");
                    numero = int.Parse(Console.ReadLine()!);

                    datoCorrecto = true; //Si el dato fue correcto, salimos del ciclo.
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine(elError.Message + "\n");
                }
            }

            //aqui verificamos que los limites conformen un rango
            if (superior > inferior)
            {
                bool estaEnElRango = ValidaRango(inferior, superior, numero);

                if (estaEnElRango)
                    Console.WriteLine("Si, el número está en el rango.");
                else
                    Console.WriteLine("No, el número no está en el rango.");
            }
            else
            {
                Console.WriteLine("Los límites ingresados no definen un rango. No se puede evaluar!");
            }
        }

        /// <summary>
        /// Función para validar si un número está en un rango
        /// </summary>
        /// <param name="datoInferior">limite inferior del rango</param>
        /// <param name="datoSuperior">limite superior del rango</param>
        /// <param name="datoNumero">el número a validar</param>
        /// <returns></returns>
        static bool ValidaRango(int datoInferior, int datoSuperior, int datoNumero)
        {
            bool resultado = false;

            if (datoNumero >= datoInferior && datoNumero <= datoSuperior)
                resultado = true;

            return resultado;
        }
    }
}

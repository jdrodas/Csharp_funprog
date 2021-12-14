/*
Programa:       ArregloEstaturas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Realice un programa en C# que lea desde consola 10 valores correspondientes a la estatura de personas expresadas en metros (ej: 1.72 m). 
Los valores serán almacenados en un arreglo. El arreglo debe ser ordenado de manera descendente, de tal manera que la estatura mayor sea 
el primer elemento y la estatura menor sea el último elemento. 

Realice una función que calcule la estatura promedio, recibiendo como parámetro el arreglo y devolviendo a la función principal el valor 
obtenido.

Adicionalmente:

•	Debe capturar la excepción de formato inválido, para garantizar que solo se ingresen valores numéricos asociados a la estatura de personas.
•	Debe implementar un ciclo de control que garantice que se tengan 10 datos válidos.
•	Visualizar todos los resultados esperados (contenido del arreglo, estatura mayor, estatura menor y estatura promedio).

 */

using System.Globalization;

namespace ArregloEstaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para leer desde consola 10 valores con decimales correspondientes a estatura de persona expresada en metros");

            //Aqui declaramos un objeto de tipo CultureInfo - Información Regional
            CultureInfo miCultura = CultureInfo.CurrentCulture;

            Console.WriteLine($"\nLa configuración regional actual es {miCultura.Name}");
            Console.WriteLine($"El separador de decimales es \"{miCultura.NumberFormat.NumberDecimalSeparator}\"");

            int posicion = 0;

            float[] arregloEstaturas = new float[10];

            //Garantizamos que los 10 valores sean correctos - Usamos ciclo While o Do-while
            while (posicion < 10)
            {
                try
                {
                    Console.Write($"Ingresa el valor para la estatura No. {posicion + 1}: ");
                    arregloEstaturas[posicion] = float.Parse(Console.ReadLine()!);

                    posicion++;
                }
                catch (FormatException error)
                {
                    Console.WriteLine("\nIngresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message} \n\n");
                }
            }

            //aqui ordenamos el arreglo de forma descendente
            Array.Sort(arregloEstaturas);
            Array.Reverse(arregloEstaturas);

            float promedio = ObtienePromedio(arregloEstaturas);

            //Aqui visualizamos resultados
            Console.WriteLine("\nLas estaturas ingresadas, ordenadas de manera descendente son:");

            for (int i = 0; i < arregloEstaturas.Length; i++)
                Console.WriteLine($"Dato No. {i + 1}, valor de la estatura: {arregloEstaturas[i]}");

            Console.WriteLine($"\nLa mayor estatura es {arregloEstaturas[0]} mientras que la menor es {arregloEstaturas[9]}");
            Console.WriteLine($"La estatura promedio es {promedio}");
        }

        /// <summary>
        /// Calcula el valor promedio de los valores recibidos en un arreglo
        /// </summary>
        /// <param name="arreglo">Arreglo con valores tipo float</param>
        /// <returns>el promedio calculado</returns>
        static float ObtienePromedio(float[] arreglo)
        {
            float promedio = 0;

            for (int i = 0; i < arreglo.Length; i++)
                promedio += arreglo[i];

            promedio /= arreglo.Length;

            return promedio;
        }
    }
}

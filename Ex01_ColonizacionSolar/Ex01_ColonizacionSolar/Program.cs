/*
Programa:       Ex01_ColonizacionSolar
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------
Examen 01: Condicionales y Ciclos de control


Colonización de Sistema Solar – Envío de Sondas exploratorias
*************************************************************

El exitoso lanzamiento del Falcon Heavy como transporte confiable interplanetario, abrió las posibilidades a la colonización 
interplanetaria, con primer objetivo el enviar sondas exploratorias más allá de Marte.

Para ello, se realizarán 12 lanzamientos de naves espaciales, direccionadas a (M)arte, (T)itán y el (C)inturón de Asteroides. 

Se requiere hacer un programa en C# que permita capturar para contabilizar, el destino de cada lanzamiento. Si el destino no 
es válido, debe repetirse el ingreso del dato. 

Posteriormente se generarán los siguientes resultados por cada destino:
- Cuántos lanzamientos fueron para cada destino.
- Indicar cuál destino fue el que más lanzamientos recibió, o si todos los destinos tuvieron la misma cantidad.

 */

using System;

namespace Ex01_ColonizacionSolar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Colonización del Sistema Solar");
            Console.WriteLine("\nSe registrarán 12 lanzamientos de naves espaciales a los destinos");
            Console.WriteLine("(M)arte, (T)itán y el (C)inturón de Asteroides.");
            Console.WriteLine("Cualquier valor diferente será registrado como error y deberá ingresarse nuevamente");

            //Aqui declaramos las variables que utilizaremos
            int totalMarte = 0, totalTitan = 0, totalCinturon = 0;
            int totalLanzamientos = 1;
            string destino = "";

            //Implementamos el ciclo de control para contar los 12 lanzamientos
            while (totalLanzamientos <= 12)
            {
                Console.Write($"\nPor favor indique el destino del lanzamiento No. {totalLanzamientos} (M/T/C): ");
                destino = Console.ReadLine()!.ToUpper();

                if (destino == "M" || destino == "T" || destino == "C")
                {
                    if (destino == "M")
                        totalMarte++;

                    if (destino == "T")
                        totalTitan++;

                    if (destino == "C")
                        totalCinturon++;

                    //Finalmente se incrementa el contador de lanzamientos, solo cuando fue registrado correctamente
                    totalLanzamientos++;
                }
                else
                {
                    Console.WriteLine("El destino no es válido. Debe ser (M)arte, (T)itán o el (C)inturón de Asteroides.");
                }
            }

            //Se visualizan resultados de lanzamientos por destino:
            Console.WriteLine($"Total de lanzamientos a Marte fueron {totalMarte}");
            Console.WriteLine($"Total de lanzamientos a Titán fueron {totalTitan}");
            Console.WriteLine($"Total de lanzamientos al Cinturón de Asteroides fueron {totalCinturon}");


            //Comparamos cual fue el que más lanzamientos obtuvo
            if (totalMarte > totalTitan && totalMarte > totalCinturon)
                Console.WriteLine("Marte fue el que obtuvo la mayor cantidad de lanzamientos!");

            if (totalTitan > totalMarte && totalTitan > totalCinturon)
                Console.WriteLine("Titán fue el que obtuvo la mayor cantidad de lanzamientos!");

            if (totalCinturon > totalTitan && totalCinturon > totalMarte)
                Console.WriteLine("El Cinturón de Asteroides fue el que obtuvo la mayor cantidad de lanzamientos!");

            //Si todos fueron iguales
            if (totalCinturon == totalTitan && totalTitan == totalMarte)
                Console.WriteLine("Todos los destinos tuvieron la misma cantidad de lanzamientos!");


        }
    }
}
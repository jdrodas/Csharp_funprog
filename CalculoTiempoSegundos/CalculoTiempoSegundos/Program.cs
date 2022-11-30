/*
Programa:       CalculoTiempoSegundos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

- Implementa un menú con opciones en consola utilizando ciclos do-while y condicionales
- Implementa una función que devuelve sus resultados a través de parámetros "out"

*/


using System;

namespace CalculoTiempoSegundos
{
    public class Program
    {
        static void Main(string[] args)
        {
            short valorOpcion;
            bool datoCorrecto;

            do
            {
                Console.WriteLine("Programa para convertir tiempo de y hacia segundos\n");
                Console.WriteLine("\t1. Segundos convertidos a Horas y Minutos");
                Console.WriteLine("\t2. Horas y Minutos convertidos a Segundos");
                Console.WriteLine("\t0. Salir del programa");

                Console.Write("\n\nSelecciona una opción: ");
                datoCorrecto = short.TryParse(Console.ReadLine(), out valorOpcion);

                //Si el dato no es correcto, debemos asignarle un valor a la opción
                //que repita el proceso. Por ejemplo, -1
                if (datoCorrecto == false)
                    valorOpcion = -1;

                //Aqui invocamos las funciones según la opción:
                if (valorOpcion == 1)
                {
                    ConvierteSegundosEnHoras();
                }

                if (valorOpcion == 2)
                {
                    ConvierteHorasEnSegundos();
                }

                if (valorOpcion != 1 && valorOpcion != 2 && valorOpcion != 0)
                {
                    Console.WriteLine("La opción ingresada no es válida. Intenta nuevamente!");
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }

                //Borramos la consola
                if (valorOpcion != 0)
                    Console.Clear();
            }
            while (valorOpcion != 0);

            //Aqui mostramos la salida
            Console.WriteLine("\n\nFin del programa");
        }

        /// <summary>
        /// Función que controla el proceso de convertir horas y minutos a segundos
        /// </summary>
        static void ConvierteHorasEnSegundos()
        {
            Console.Clear();
            Console.WriteLine("Conversión de Horas y Minutos en segundos");
            bool datoHoraCorrecto = false, datoMinutoCorrecto = false;
            uint horas, minutos, segundos;

            do
            {
                Console.Write("\nIngresa la cantidad de horas: ");
                datoHoraCorrecto = uint.TryParse(Console.ReadLine(), out horas);

                Console.Write("Ingresa la cantidad de minutos: ");
                datoMinutoCorrecto = uint.TryParse(Console.ReadLine(), out minutos);

                //Aqui validamos que los minutos estén en el intervalo [0;59)
                if (minutos >= 60)
                {
                    Console.WriteLine("\nEl valor de los minutos no debe ser superior a 59. Intenta nuevamente");
                    datoMinutoCorrecto = false;
                }

                if (datoHoraCorrecto == true && datoMinutoCorrecto == true)
                {
                    segundos = (horas * 3600) + (minutos * 60);

                    Console.WriteLine($"{horas} horas y {minutos} minutos corresponden a " +
                        $"{segundos} segundos");

                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                }

                else
                    Console.WriteLine("Los datos ingresados son inválidos. Intenta nuevamente!");

            }
            while (datoHoraCorrecto == false || datoMinutoCorrecto == false);
        }

        /// <summary>
        /// Función que controla el proceso de convertir un dato en segundos 
        /// en horas y minutos
        /// </summary>
        static void ConvierteSegundosEnHoras()
        {
            Console.Clear();
            Console.WriteLine("Conversión de segundos en Horas y Minutos");

            bool datoCorrecto = false;
            uint segundos = 0;
            uint horas, minutos, residuoSegundos;

            while (datoCorrecto == false)
            {
                Console.Write("\n\nIngresa la cantidad de segundos: ");
                datoCorrecto = uint.TryParse(Console.ReadLine(), out segundos);

                if (datoCorrecto == false)
                    Console.WriteLine("El valor ingresado no es válido. Intenta nuevamente!");
                else
                {
                    ObtieneHorasMinutos(segundos, out horas, out minutos, out residuoSegundos);

                    Console.WriteLine($"{segundos} segundos equivalen a {horas} horas, " +
                        $"{minutos} minutos y {residuoSegundos} segundos");

                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Función que descompone un total de segundos en sus equivalentes de hora, minutos y segundos
        /// </summary>
        /// <param name="datoSegundos">valor total de segundos</param>
        /// <param name="datoHoras">componente de horas</param>
        /// <param name="datoMinutos">componente de minutos</param>
        /// <param name="datoResiduoSegundos">componente de segundos</param>
        static void ObtieneHorasMinutos(uint datoSegundos, out uint datoHoras, out uint datoMinutos, out uint datoResiduoSegundos)
        {
            //Calculamos las horas
            datoHoras = datoSegundos / 3600;
            datoMinutos = (datoSegundos % 3600) / 60;
            datoResiduoSegundos = (datoSegundos % 60);
        }
    }
}

using System;

namespace EX02_RiesgosInundaciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monitoreo de Riesgo de Inundaciones en Antioquia");
            Console.WriteLine("Se analizarán 12 eventos de inundaciones para identificar hogares afectados");
            Console.WriteLine("Se vigilarán inundaciones (F) Fluviales, (C) Costeras, (U) urbanas");

            int totalEventosInundaciones = 1;
            int[] EventosPorTipo = new int[3];
            int[] hogaresAfectadosPorTipo = new int[3];
            string[] nombresTiposInundaciones = { "Fluviales", "Costeras", "Urbanas" };
            string tipoInundacion;
            int hogaresAfectados;

            // Inicializamos el contador
            // Posición 0: Fluviales, Posicion 1: Costeras, Posición 2: Urbanas
            for (int i = 0; i < EventosPorTipo.Length; i++)
            {
                EventosPorTipo[i] = 0;
                hogaresAfectadosPorTipo[i] = 0;
            }

            while (totalEventosInundaciones <= 12)
            {
                Console.Write($"\nIngresa el tipo de inundación (F/C/U) para el evento No. {totalEventosInundaciones}: ");
                tipoInundacion = Console.ReadLine()!.ToUpper();

                if (tipoInundacion == "F" || tipoInundacion == "C" || tipoInundacion == "U")
                {
                    try
                    {
                        //Preguntamos por la cantidad de hogares afectados en este evento:
                        Console.Write("Cuantos Hogares fueron afectados en este evento: ");
                        hogaresAfectados = int.Parse(Console.ReadLine()!);

                        if (hogaresAfectados < 0 || hogaresAfectados > 100)
                            Console.WriteLine("La cantidad de hogares afectados debe estar en el rango [0;100]. Intenta nuevamente.");
                        else 
                        {
                            switch (tipoInundacion)
                            {
                                case "F":
                                    EventosPorTipo[0]++;
                                    hogaresAfectadosPorTipo[0] += hogaresAfectados;
                                    break;

                                case "C":
                                    EventosPorTipo[1]++;
                                    hogaresAfectadosPorTipo[1] += hogaresAfectados;
                                    break;

                                case "U":
                                    EventosPorTipo[2]++;
                                    hogaresAfectadosPorTipo[2] += hogaresAfectados;
                                    break;
                            }

                            totalEventosInundaciones++;
                        }
                    }
                    catch (FormatException unError)
                    {
                        Console.WriteLine("La cantidad de hogares es un dato numérico, intenta nuevamente");
                        Console.WriteLine(unError.Message);
                    }
                }
                else
                {
                    Console.WriteLine("El tipo de inundación seleccionado no es válido. Intenta nuevamente");
                }
            }

            float[] promediosAfectacion = CalculaPromedioAfectacion(hogaresAfectadosPorTipo, EventosPorTipo);

            Console.WriteLine("\n *** Resultados Obtenidos ***\n");

            for (int i = 0; i < EventosPorTipo.Length; i++)
            {
                Console.WriteLine($"Tipo inundación: {nombresTiposInundaciones[i]}, " +
                    $"Total eventos: {EventosPorTipo[i]}, " +
                    $"Hogares afectados: {hogaresAfectadosPorTipo[i]}, " +
                    $"Promedio afectación: {promediosAfectacion[i].ToString(".00")}");
            }
        }

        static float[] CalculaPromedioAfectacion(int[] arregloHogaresAfectados, int[] arregloEventos)
        {
            float[] losPromedios = new float[arregloEventos.Length];

            for (int i = 0; i < losPromedios.Length; i++)
            {
                losPromedios[i] = (float)(arregloHogaresAfectados[i])/arregloEventos[i];
            }

            return losPromedios;
        }
    }
}
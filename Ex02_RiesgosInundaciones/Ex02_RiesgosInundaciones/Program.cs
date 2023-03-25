using System;

namespace EX02_RiesgosInundaciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monitoreo de Riesgo de Inundaciones de 12 eventos");
            Console.WriteLine("Estos son los tipos de inundaciones");

            string[] tiposInundaciones = { "Fluvial", "Costera", "Urbana" };

            //Console.WriteLine($"El arreglo de tipos de inundaciones " +
            //    $"tiene {tiposInundaciones.Length} posiciones");

            foreach (string tipo in tiposInundaciones)
                Console.WriteLine($"- {tipo}");

            //Posición 0: Fluvial
            //Posición 1: Costera
            //Posición 2: Urbana
            int[] totalEventos = new int[tiposInundaciones.Length];
            int[] totalHogaresAfectados = new int[tiposInundaciones.Length];
            float[] promediosAfectacion = new float[tiposInundaciones.Length];

            for (int i = 0; i < tiposInundaciones.Length; i++)
            {
                totalEventos[i] = 0;
                totalHogaresAfectados[i] = 0;
                promediosAfectacion[i] = 0;
            }

            int contadorEventos = 1;
            string tipoIngresado;
            int cantidadHogaresAfectados;

            while (contadorEventos <= 12)
            {
                Console.Write($"\nCual fue el tipo de inundación (fluvial/costera/urbana) para el evento No. {contadorEventos}: ");
                tipoIngresado = Console.ReadLine()!.ToLower();

                if (tipoIngresado == "fluvial" || tipoIngresado == "costera" || tipoIngresado == "urbana")
                {
                    try
                    {
                        Console.Write($"Ingresa la cantidad de hogares afectados por la inundación {tipoIngresado}: ");
                        cantidadHogaresAfectados = int.Parse(Console.ReadLine()!);

                        if (cantidadHogaresAfectados >= 0 && cantidadHogaresAfectados <= 100)
                        {
                            switch (tipoIngresado)
                            {
                                case "fluvial":
                                    totalEventos[0]++;
                                    totalHogaresAfectados[0] += cantidadHogaresAfectados;
                                    break;

                                case "costera":
                                    totalEventos[1]++;
                                    totalHogaresAfectados[1] += cantidadHogaresAfectados;
                                    break;

                                case "urbana":
                                    totalEventos[2]++;
                                    totalHogaresAfectados[2] += cantidadHogaresAfectados;
                                    break;
                            }

                            contadorEventos++;
                        }
                        else
                        {
                            Console.WriteLine("Ingresaste una cantidad fuera del rango [0;100]. Intenta nuevamente");
                        }
                    }
                    catch (FormatException unError)
                    {
                        Console.WriteLine("El dato Ingresado no es numerico. Intenta nuevamente");
                        Console.WriteLine(unError.Message);
                    }
                }
                else
                {
                    Console.WriteLine("El tipo ingresado no es válido. Intenta nuevamente");
                }
            }

            //Aqui calculamos los promedios
            promediosAfectacion = CalculaPromedioAfectacion(totalHogaresAfectados, totalEventos);

            Console.WriteLine("\n *** Resultados Obtenidos ***\t");
            for (int i = 0; i < tiposInundaciones.Length; i++)
            {
                Console.WriteLine($"Tipo de inundación: {tiposInundaciones[i]}, " +
                    $"Total Eventos: {totalEventos[i]}, " +
                    $"Hogares Afectados: {totalHogaresAfectados[i]}, " +
                    $"Promedio Afectación: {promediosAfectacion[i]}");
            }
        }

        static float[] CalculaPromedioAfectacion(int[] arregloHogaresAfectados, int[] arregloTotalEventos)
        {
            float[] losPromedios = new float[arregloHogaresAfectados.Length];

            for (int i = 0; i < losPromedios.Length; i++)
            {
                if (arregloTotalEventos[i] != 0)
                    losPromedios[i] = Convert.ToSingle(arregloHogaresAfectados[i]) / arregloTotalEventos[i];
                else
                    losPromedios[i] = 0;
            }

            return losPromedios;
        }
    }
}
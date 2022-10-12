using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_ViajesMetroplus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular viajes en Metroplus");

            string[] nombresRutas = new string[5];

            int contadorRutas = 0;
            while (contadorRutas < nombresRutas.Length)
            {
                Console.Write($"\nIngresa el nombre para la ruta No. {contadorRutas + 1}: ");
                nombresRutas[contadorRutas] = Console.ReadLine();

                if (nombresRutas[contadorRutas].Length > 0)
                    contadorRutas++;
                else
                    Console.WriteLine("El dato ingresado no es válido. Intenta nuevamente!");
            }

            // Aqui declaramos e inicializamos el arreglo de viajes
            Random aleatorio = new Random();
            Viaje[] losViajes = new Viaje[100];

            for (int i = 0; i < losViajes.Length; i++)
            {
                losViajes[i] = new Viaje();
                losViajes[i].Ruta = nombresRutas[aleatorio.Next(nombresRutas.Length)];
                losViajes[i].CantidadPasajeros = aleatorio.Next(5, 41);
            }

            //Aqui totalizamos los pasajeros para cada ruta
            int[] totalPasajerosRuta = TotalizaPasajerosRuta(losViajes, nombresRutas);

            //Aqui calculamos el porcentaje de pasajeros transportados por ruta
            float[] porcentajesPasajeros = ObtienePorcentajeRuta(totalPasajerosRuta);


            //Aqui visualizamos resultados
            Console.WriteLine("\n\nResultados del transporte del día");

            for (int i = 0; i < nombresRutas.Length; i++)
            {
                Console.WriteLine($"\nRuta: {nombresRutas[i]}, Total Pasajeros: {totalPasajerosRuta[i]}, \n" +
                    $"Porcentaje: {porcentajesPasajeros[i].ToString("0.000")}%");
            }

            //Aqui identificamos la ruta de menor cantidad de pasajeros
            int pasajerosRutaMenor = 0;
            string nombreRutaMenor = "";

            ObtieneRutaMenorPasajeros(totalPasajerosRuta, 
                nombresRutas, 
                out nombreRutaMenor, 
                out pasajerosRutaMenor);

            Console.WriteLine($"\nLa ruta con menor cantidad de pasajeros " +
                $"fue {nombreRutaMenor} que transportó {pasajerosRutaMenor} pasajeros");
        }

        static void ObtieneRutaMenorPasajeros(int[] totalPasajerosRuta,
                                              string[] nombresRutas,
                                              out string nombreRutaMenor,
                                              out int pasajerosRutaMenor)
        {
            //Arbitrariamente designamos la primera ruta como la ruta de menores pasajeros transportados
            nombreRutaMenor = nombresRutas[0];
            pasajerosRutaMenor = totalPasajerosRuta[0];

            //Recorremos el RESTO de las rutas identificando si hay alguna con menor cantidad de pasajeros
            for (int i = 1; i < totalPasajerosRuta.Length; i++)
            {
                if (totalPasajerosRuta[i] < pasajerosRutaMenor)
                {
                    nombreRutaMenor = nombresRutas[i];
                    pasajerosRutaMenor = totalPasajerosRuta[i];
                }
            }
        }

        /// <summary>
        /// Obtiene el porcentaje de pasajeros que se transportaron por cada ruta
        /// </summary>
        /// <param name="totalesPasajerosRuta">Totales de pasajeros por ruta</param>
        /// <returns>Porcentaje del total de pasajeros por cada ruta</returns>
        static float[] ObtienePorcentajeRuta(int[] totalesPasajerosRuta)
        {
            float[] porcentajeRuta = new float[totalesPasajerosRuta.Length];

            //Primero, obtenemos el total de pasajeros de todas las rutas
            int totalPasajerosDia = 0;

            for (int i = 0; i < totalesPasajerosRuta.Length; i++)
                totalPasajerosDia += totalesPasajerosRuta[i];

            for (int i = 0; i < totalesPasajerosRuta.Length; i++)
                porcentajeRuta[i] = 100f * totalesPasajerosRuta[i] / totalPasajerosDia;

            return porcentajeRuta;
        }

        /// <summary>
        /// Calcula el total de pasajeros por ruta en un día de transporte
        /// </summary>
        /// <param name="arregloViajes">El arreglo de viajes</param>
        /// <param name="arregloRutas">Las rutas</param>
        /// <returns>Totales de pasajeros por ruta</returns>
        static int[] TotalizaPasajerosRuta(Viaje[] arregloViajes, string[] arregloRutas)
        {
            int[] totalPasajeros = new int[arregloRutas.Length];

            for (int i = 0; i < totalPasajeros.Length; i++)
                totalPasajeros[i] = 0;

            //Aqui recorremos el arreglo de viajes y si la ruta coincide con la actual, 
            //incrementamos el totalizador de pasajeros
            for (int j = 0; j < arregloViajes.Length; j++)
            {
                for (int k = 0; k < arregloRutas.Length; k++)
                {
                    if (arregloViajes[j].Ruta == arregloRutas[k])
                        totalPasajeros[k] += arregloViajes[j].CantidadPasajeros;
                }
            }

            return totalPasajeros;
        }
    }
}

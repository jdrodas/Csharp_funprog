using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_ServiciosPublicos
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Programa para simular el análisis de consumo de servicios públicos");
            Console.WriteLine("Se generarán 1.000 registros aleatorios para Energía, Acueducto, Gas, Telefonía Local e Internet\n");

            //Se declara arreglo con el nombre de los servicios
            string[] nombresServicio = new string[] { "Energia", "Acueducto", "Gas", "Telefonia Local", "Internet" };

            //Se declara el arreglo de servicios
            Servicio[] losServicios = new Servicio[1000];

            Random aleatorio = new Random();

            //Inicializamos el arreglo con valores aleatorios
            for (int i = 0; i < losServicios.Length; i++)
            {
                losServicios[i] = new Servicio();
                losServicios[i].Nombre = nombresServicio[aleatorio.Next(nombresServicio.Length)];
                losServicios[i].Consumo = aleatorio.Next(10000, 100001); // 1 más para incluir el limite superior
            }

            //Los arreglos que tendrán los resultados;
            int[] totalesServicio;
            float[] promediosServicio;

            /* **************************************************************************************
             Opción 1: Las funciones reciben el arreglo de servicios y la cantidad de servicios
            ************************************************************************************** */

            //Invocamos la funcion de calcular Totales por servicio
            totalesServicio = CalculaTotales(losServicios, nombresServicio.Length);

            //Invocamos la función de calcular los promedios por servicio
            promediosServicio = CalculaPromedios(losServicios, nombresServicio.Length);

            //Visualizamos los resultados

            Console.WriteLine("\n\nResultados obtenidos - Opción 1 - Funciones con parametro de cantidad de servicios:\n");
            int totalElementos = 0;

            for (int i = 0; i < nombresServicio.Length; i++)
            {
                Console.WriteLine($"{nombresServicio[i]}: {totalesServicio[i]} registros, con promedio consumo de {promediosServicio[i]} pesos");
                totalElementos += totalesServicio[i];
            }

            Console.WriteLine($"\nTotal Elementos: {totalElementos}\n");

            /* **************************************************************************************
             Opción 2: Las funciones reciben el arreglo de servicios y el arreglo de nombres
            ************************************************************************************** */

            //Invocamos la funcion de calcular Totales por servicio
            totalesServicio = CalculaTotalesConNombre(losServicios, nombresServicio);

            //Invocamos la función de calcular los promedios por servicio
            promediosServicio = CalculaPromediosConNombre(losServicios, nombresServicio);

            //Visualizamos los resultados

            Console.WriteLine("\n\nResultados obtenidos - Opción 1 - Funciones con parametro de cantidad de servicios:\n");
            totalElementos = 0;

            for (int i = 0; i < nombresServicio.Length; i++)
            {
                Console.WriteLine($"{nombresServicio[i]}: {totalesServicio[i]} registros, con promedio consumo de {promediosServicio[i]} pesos");
                totalElementos += totalesServicio[i];
            }

            Console.WriteLine($"\nTotal Elementos: {totalElementos}\n");

        }

        static float[] CalculaPromedios(Servicio[] arregloServicios, int totalServicios)
        {
            float[] promedios = new float[totalServicios];

            //Inicializamos el arreglo de promedios
            for (int i = 0; i < promedios.Length; i++)
                promedios[i] = 0;

            //Necesitamos saber los totales para los promedios, asi que invocamos la función
            int[] totales = CalculaTotales(arregloServicios, totalServicios);

            //Ahora buscamos cual es el consumo promedio por cada servicio
            for (int i = 0; i < arregloServicios.Length; i++)
            {
                if (arregloServicios[i].Nombre == "Energia")
                    promedios[0] += arregloServicios[i].Consumo;

                if (arregloServicios[i].Nombre == "Acueducto")
                    promedios[1] += arregloServicios[i].Consumo;

                if (arregloServicios[i].Nombre == "Gas")
                    promedios[2] += arregloServicios[i].Consumo;

                if (arregloServicios[i].Nombre == "Telefonia Local")
                    promedios[3] += arregloServicios[i].Consumo;

                if (arregloServicios[i].Nombre == "Internet")
                    promedios[4] += arregloServicios[i].Consumo;
            }

            //finalmente calculamos el promedio teniendo en cuenta la cantidad de elementos por cada servicio
            for (int i = 0; i < totalServicios; i++)
                promedios[i] /= totales[i];

            return promedios;
        }

        static float[] CalculaPromediosConNombre(Servicio[] arregloServicios, string[] nombresServicios)
        {
            float[] promedios = new float[nombresServicios.Length];

            //Inicializamos el arreglo de promedios
            for (int i = 0; i < promedios.Length; i++)
                promedios[i] = 0;

            //Necesitamos saber los totales para los promedios, asi que invocamos la función
            int[] totales = CalculaTotalesConNombre(arregloServicios, nombresServicios);

            //Ahora buscamos cual es el consumo promedio por cada servicio
            for (int i = 0; i < arregloServicios.Length; i++)
                for (int j = 0; j < nombresServicios.Length; j++)
                    if (arregloServicios[i].Nombre == nombresServicios[j])
                        promedios[j] += arregloServicios[i].Consumo;


            //finalmente calculamos el promedio teniendo en cuenta la cantidad de elementos por cada servicio
            for (int i = 0; i < nombresServicios.Length; i++)
                promedios[i] /= totales[i];

            return promedios;
        }

        static int[] CalculaTotalesConNombre(Servicio[] arregloServicios, string[] nombresServicios)
        {
            int[] totales = new int[nombresServicios.Length];

            //Inicializamos el arreglo de totales
            for (int i = 0; i < totales.Length; i++)
                totales[i] = 0;

            //Contamos cuantos elementos hay en el arreglo por cada servicio
            for (int i = 0; i < arregloServicios.Length; i++)       
                for (int j = 0; j < nombresServicios.Length; j++)                
                    if (arregloServicios[i].Nombre == nombresServicios[j])
                        totales[j]++;

            return totales;
        }

        /// <summary>
        /// Cuenta cuantos elementos hay por cada servicio en el arreglo
        /// </summary>
        /// <param name="arregloServicios">El arreglo de servicios</param>
        /// <param name="totalServicios">la cantidad de servicios</param>
        /// <returns>arreglo con los valores totales por servicio</returns>
        static int[] CalculaTotales(Servicio[] arregloServicios, int totalServicios)
        {
            int[] totales = new int[totalServicios];

            //Inicializamos el arreglo de totales
            for (int i = 0; i < totales.Length; i++)
                totales[i] = 0;

            //Contamos cuantos elementos hay en el arreglo por cada servicio
            for (int i = 0; i < arregloServicios.Length; i++)
            {
                if (arregloServicios[i].Nombre == "Energia")
                    totales[0]++;

                if (arregloServicios[i].Nombre == "Acueducto")
                    totales[1]++;

                if (arregloServicios[i].Nombre == "Gas")
                    totales[2]++;

                if (arregloServicios[i].Nombre == "Telefonia Local")
                    totales[3]++;

                if (arregloServicios[i].Nombre == "Internet")
                    totales[4]++;
            }

            return totales;
        }
    }
}

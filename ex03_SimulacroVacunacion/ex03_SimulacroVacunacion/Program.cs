using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03_SimulacroVacunacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulación de Vacunación Masiva");
            Console.WriteLine("Se simula 1000 vacunados, preguntando edad, ciudad y biológico. \n\n");

            //Aqui definimos los biológicos a utilizar en la vacunacion
            string[] losBiologicos = {
                    "Pfizer",
                    "Sinovac",
                    "Astra-Zeneca",
                    "Johnson y Johnson",
                    "Moderna"
            };

            //Aqui capturamos la información de las ciudades
            string[] lasCiudades = new string[5];

            Console.WriteLine("Ingreso de ciudades para la simulación:");

            for (int i = 0; i < lasCiudades.Length; i++)
            {
                Console.Write($"Ingresa el nombre de la ciudad No. {i + 1}: ");
                lasCiudades[i] = Console.ReadLine();
            }

            Console.Write("\n\nInicializando los elementos de la simulación... ");

            Random aleatorio = new Random();

            Vacunado[] losVacunados = new Vacunado[1000];

            for (int i = 0; i < losVacunados.Length; i++)
            {
                losVacunados[i] = new Vacunado();
                losVacunados[i].Edad = aleatorio.Next(20, 91);
                losVacunados[i].Biologico = losBiologicos[aleatorio.Next(losBiologicos.Length)];
                losVacunados[i].CiudadResidencia = lasCiudades[aleatorio.Next(lasCiudades.Length)];
            }

            Console.WriteLine("Finalizado!");

            //Aqui llamamos las funciones que calculan los totales y calculan los promedios

            int[] totalesCiudades = CalculaTotalesCiudad(losVacunados, lasCiudades);
            int[] totalesBiologico = CalculaTotalesBiologico(losVacunados, losBiologicos);

            float[] promEdadCiudades = CalculaEdadPromedioCiudad(losVacunados, lasCiudades);
            float[] promEdadBiologicos = CalculaEdadPromedioBiologico(losVacunados, losBiologicos);

            Console.WriteLine("\n\nVisualizando Resultados:");

            Console.WriteLine("\nResultado por ciudad:");

            for (int i = 0; i < lasCiudades.Length; i++)
                Console.WriteLine($"Ciudad: {lasCiudades[i]}, total vacunados: {totalesCiudades[i]}, edad promedio: {promEdadCiudades[i].ToString("0.00")}");


            Console.WriteLine("\nResultado por biológico:");

            for (int i = 0; i < losBiologicos.Length; i++)
                Console.WriteLine($"Biológico: {losBiologicos[i]}, total vacunados: {totalesBiologico[i]}, edad promedio: { promEdadBiologicos[i].ToString("0.00")}");
          
        }

        static int[] CalculaTotalesBiologico(Vacunado[] losVacunados, string[] losBiologicos)
        {
            int[] resultado = new int[losBiologicos.Length];

            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //totalizamos cuantos vacunados se encontraron por cada biológico
            for (int i = 0; i < losVacunados.Length; i++)
            {
                for (int j = 0; j < losBiologicos.Length; j++)
                    if (losVacunados[i].Biologico == losBiologicos[j])
                        resultado[j]++;
            }

            return resultado;
        }

        static int[] CalculaTotalesCiudad(Vacunado[] losVacunados, string[] lasCiudades)
        {
            int[] resultado = new int[lasCiudades.Length];

            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //totalizamos cuantos vacunados se encontraron por cada biológico
            for (int i = 0; i < losVacunados.Length; i++)
            {
                for (int j = 0; j < lasCiudades.Length; j++)
                    if (losVacunados[i].CiudadResidencia == lasCiudades[j])
                        resultado[j]++;
            }

            return resultado;
        }

        static float[] CalculaEdadPromedioCiudad(Vacunado[] losVacunados, string[] lasCiudades)
        {
            //Aqui obtenemos los totales de las ciudades para calcular posteriormente el promedio
            int[] totalesCiudades = CalculaTotalesCiudad(losVacunados, lasCiudades);

            float[] resultado = new float[lasCiudades.Length];
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //Aqui recorremos el arreglo de vacunados para acumular las edades según la ciudad
            for (int i = 0; i < losVacunados.Length; i++)
            {
                for (int j = 0; j < lasCiudades.Length; j++)
                    if (losVacunados[i].CiudadResidencia == lasCiudades[j])
                        resultado[j] += losVacunados[i].Edad;
            }

            //Luego, se divide cada posición del resultado, por el total de vacunados de cada ciudad
            for(int i =0; i<resultado.Length;i++)
                resultado[i] = resultado[i] / totalesCiudades[i];

            return resultado;
        }

        static float[] CalculaEdadPromedioBiologico(Vacunado[] losVacunados, string[] losBiologicos)
        {
            //Aqui obtenemos los totales de los biológicos para calcular posteriormente el promedio
            int[] TotalesBiologicos = CalculaTotalesBiologico(losVacunados, losBiologicos);

            float[] resultado = new float[losBiologicos.Length];
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //Aqui recorremos el arreglo de vacunados para acumular las edades según el biológico
            for (int i = 0; i < losVacunados.Length; i++)
            {
                for (int j = 0; j < losBiologicos.Length; j++)
                    if (losVacunados[i].Biologico == losBiologicos[j])
                        resultado[j] += losVacunados[i].Edad;
            }

            //Luego, se divide cada posición del resultado, por el total de vacunados de cada biológico
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = resultado[i] / TotalesBiologicos[i];

            return resultado;
        }
    }
}

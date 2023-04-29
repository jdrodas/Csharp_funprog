using System;

namespace Ex03_PavimentacionCalles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular la pavimentación de tramos de calle");
            Console.WriteLine("Las calles tendrán una longitud entre 100 y 500 mts");
            Console.WriteLine("Los tramos deteriorados tienen una longitud relativa entre el 20 y 60%");
            Console.WriteLine("\nSe repararán calles por los siguientes deterioros");

            string[] losDeterioros = { "Agrietamientos", "Hundimientos", "Ondulaciones" };

            foreach (string deterioro in losDeterioros)
                Console.WriteLine($"- {deterioro}");

            //1. Obtener la cantidad de calles a pavimentar
            int cantidadCalles = 0;
            bool datoCorrecto = false;

            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de calles a pavimentar: ");
                    cantidadCalles = int.Parse(Console.ReadLine()!);

                    if (cantidadCalles > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad de calles debe ser un entero positivo. Intenta nuevamente!");
                }
                catch (FormatException unError)
                {
                    Console.WriteLine("La cantidad de calles debe ser un entero positivo. Intenta nuevamente");
                    Console.WriteLine(unError.Message);
                }
            }
            while (!datoCorrecto);

            //2. Declarar e inicializar un arreglo de calles
            Calle[] lasCalles = new Calle[cantidadCalles];
            Random aleatorio = new Random();

            for (int i = 0; i < lasCalles.Length; i++)
            {
                lasCalles[i] = new Calle();
                lasCalles[i].TipoDeterioro = losDeterioros[aleatorio.Next(losDeterioros.Length)];
                lasCalles[i].Longitud = aleatorio.Next(100, 501);
                lasCalles[i].TramoAfectado = 20 + aleatorio.NextDouble() * (60-20);
            }

            //3. Visualización detalle de las calles simuladas
            Console.WriteLine("\n\n*** Resultados de la simulación ***\n");

            for (int i = 0; i < lasCalles.Length; i++)
            {
                Console.WriteLine($"\nCalle No. {(i + 1)}: \nDeterioro: {lasCalles[i].TipoDeterioro}, " +
                    $"Longitud de la calle: {lasCalles[i].Longitud}, " +
                    $"tramo afectado: {lasCalles[i].TramoAfectado.ToString(".00")}% ");
            }

            //4. Visualizar los totales por cada tipo de deterioro
            int[] totalAfectacionesPorDeterioro = TotalizaAfectacionesPorDeterioro(lasCalles, losDeterioros);
            
            double[] cantidadPavimento = ObtieneCantidadCallePavimentadaPorDeterioro(lasCalles, losDeterioros);

            double[] longitudesPromedio = ObtieneLongitudPromedioTramosPorDeterioro(lasCalles, losDeterioros);

            Console.WriteLine("\n\n*** Totales por tipo de deterioro ***\n");

            for (int i = 0; i < losDeterioros.Length; i++)
            {
                Console.WriteLine($"\n{losDeterioros[i]}:\n" +
                    $"Total afectaciones: {totalAfectacionesPorDeterioro[i]} . " +
                    $"Total mts pavimentados: {cantidadPavimento[i].ToString(".00")} mts. " +
                    $"para una longitud promedio de {longitudesPromedio[i].ToString("0.00")} mts\n");
            }

        }

        static int[] TotalizaAfectacionesPorDeterioro(Calle[] lasCalles, string[] losDeterioros)
        {
            int[] totalAfectaciones = new int[losDeterioros.Length];

            for (int i = 0; i < lasCalles.Length; i++)
                for (int j = 0; j < losDeterioros.Length; j++)
                    if (lasCalles[i].TipoDeterioro == losDeterioros[j])
                        totalAfectaciones[j]++;

            return totalAfectaciones;
        }

        static double[] ObtieneCantidadCallePavimentadaPorDeterioro(Calle[] lasCalles, string[] losDeterioros)
        {
            double[] cantidades = new double[losDeterioros.Length];

            for (int i = 0; i < lasCalles.Length; i++)
                for (int j = 0; j < losDeterioros.Length; j++)
                    if (lasCalles[i].TipoDeterioro == losDeterioros[j])
                    {
                        cantidades[j] += lasCalles[i].Longitud *
                            (lasCalles[i].TramoAfectado / 100);
                    }

            return cantidades;
        }

        static double[] ObtieneLongitudPromedioTramosPorDeterioro(Calle[] lasCalles, string[] losDeterioros)
        {
            double[] longitudesPromedio = new double[losDeterioros.Length];
            int[] totalAfectaciones = TotalizaAfectacionesPorDeterioro(lasCalles, losDeterioros);
            double[] TotalPavimentoPorDeterioro = ObtieneCantidadCallePavimentadaPorDeterioro(lasCalles, losDeterioros);

            for (int i = 0; i < losDeterioros.Length; i++)
                longitudesPromedio[i] = TotalPavimentoPorDeterioro[i] / totalAfectaciones[i];

            return longitudesPromedio;
        }
    }
}
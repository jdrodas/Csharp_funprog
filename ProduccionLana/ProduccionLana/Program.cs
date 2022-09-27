using System;

namespace ProduccionLana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular la producción de lana de un rebaño de 100 ovejas");

            //Declaramos el arreglo de ovejas
            Oveja[] lasOvejas = new Oveja[100];

            Random aleatorio = new Random();

            //Aqui lo inicializamos
            for (int i = 0; i < lasOvejas.Length; i++)
            {
                lasOvejas[i] = new Oveja();
                lasOvejas[i].Edad = aleatorio.Next(1, 121);
                lasOvejas[i].Peso = aleatorio.Next(1, 51);
                lasOvejas[i].CantidadLana = aleatorio.Next(11);
                lasOvejas[i].EvaluaAptitud();
            }

            //Aqui contamos cuantas ovejas resultaron aptas
            //Aqui contamos cuanta lana produjeron las ovejas aptas
            int totalAptas = 0, totalLanaProducida = 0;

            foreach (Oveja unaOveja in lasOvejas)
            {
                if (unaOveja.EsApta)
                {
                    totalAptas++;
                    totalLanaProducida += unaOveja.CantidadLana;
                }
            }

            //Cuanto dinero ganó el granjero, vendiendo a $18.000 el Kg de lana
            int totalVentaLana = 18000 * totalLanaProducida;

            //Aqui finalmente visualizamos resultados:
            Console.WriteLine("\nResultados de la simulación");
            Console.WriteLine("Estas fueron las Ovejas aptas:");

            for (int k = 0; k < lasOvejas.Length; k++)
            {
                if (lasOvejas[k].EsApta)
                {
                    Console.WriteLine($"Oveja No. {k + 1}, Edad: {lasOvejas[k].Edad}, " +
                        $"Peso: {lasOvejas[k].Peso}, Cantidad Lana: {lasOvejas[k].CantidadLana}");
                }
            }

            // Con un ciclo While
            //int k = 0;
            //while (k < lasOvejas.Length)
            //{
            //    if (lasOvejas[k].EsApta)
            //    {
            //        Console.WriteLine($"Oveja No. {k + 1}, Edad: {lasOvejas[k].Edad}, " +
            //            $"Peso: {lasOvejas[k].Peso}, Cantidad Lana: {lasOvejas[k].CantidadLana}");
            //    }
            //    k++; //La sentencia que causa que la condición del while sea eventualmente falsa y se deje de repetir
            //}

            // Con un ciclo Do-While
            //int k = 0;
            //do
            //{
            //    if (lasOvejas[k].EsApta)
            //    {
            //        Console.WriteLine($"Oveja No. {k + 1}, Edad: {lasOvejas[k].Edad}, " +
            //            $"Peso: {lasOvejas[k].Peso}, Cantidad Lana: {lasOvejas[k].CantidadLana}");
            //    }
            //    k++; //La sentencia que causa que la condición del while sea eventualmente falsa y se deje de repetir
            //} while (k < lasOvejas.Length);

            Console.WriteLine($"\nTotal ovejas aptas para esquilar: {totalAptas}");
            Console.WriteLine($"Total Kg de lana producida: {totalLanaProducida}");
            Console.WriteLine($"Total Dinero obtenido: {totalVentaLana}");

            //Validar si se cumplió la meta de producir 50 Kg de lana
            if (totalLanaProducida >= 50)
                Console.WriteLine($"Se cumplió la meta de producción de 50 kg lana con {totalLanaProducida}");
            else
                Console.WriteLine($"No se alcanzó la meta. Tan solo se produjo {totalLanaProducida}");
        }
    }
}

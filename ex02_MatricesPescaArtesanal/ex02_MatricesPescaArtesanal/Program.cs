using System;

namespace ex02_MatricesPescaArtesanal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Programa para el control de la pesca artesanal ***");

            string[] nombresEspecie = { "Sabaleta", "Tilapia", "Trucha", "Mojarra" };
            string[] nombresMetodos = { "Atarraya", "Chinchorro", "Arpón", "Red de Arrastre" };

            Console.WriteLine("\nLas especies permitidas son:");
            foreach (string especiePescado in nombresEspecie)
                Console.WriteLine($" - {especiePescado}");

            Console.WriteLine("\nLos métodos de pesca auorizados son:");
            foreach (string metodoPesca in nombresMetodos)
                Console.WriteLine($" - {metodoPesca}");

            //Aqui declaramos la matriz de las cantidades
            //Dimensión 0: Especies
            //Dimensión 1: Metodos
            float[,] cantidadesPesca = new float[nombresEspecie.Length, nombresMetodos.Length];

            int contadorEspecie = 0;
            int contadorMetodos;

            while (contadorEspecie < nombresEspecie.Length)
            {
                contadorMetodos = 0;
                while (contadorMetodos < nombresMetodos.Length)
                {
                    try
                    {
                        Console.Write($"\nPesca para {nombresEspecie[contadorEspecie]} con {nombresMetodos[contadorMetodos]}: ");
                        cantidadesPesca[contadorEspecie, contadorMetodos] = float.Parse(Console.ReadLine());

                        if (cantidadesPesca[contadorEspecie, contadorMetodos] >= 0)
                            contadorMetodos++;
                        else
                            Console.WriteLine("El dato númerico no representa una cantidad. Intenta nuevamente!");
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                        Console.WriteLine(elError.Message);
                    }
                }
                contadorEspecie++;
            }

            float promedioPesca = ObtienePromedioPesca(cantidadesPesca);

            //Aqui visualizamos resultados
            Console.WriteLine("\n\n *** Resultados de la jornada de pesca ***");
            for (int i = 0; i < nombresEspecie.Length; i++)
            {
                for (int j = 0; j < nombresMetodos.Length; j++)
                {
                    Console.WriteLine($"\nEspecie {nombresEspecie[i]}, Método {nombresMetodos[j]}" +
                        $" se pescó {cantidadesPesca[i, j]} kgs");
                    if (cantidadesPesca[i, j] > 200)
                        Console.WriteLine("Se superó el tope máximo!");
                    else
                        Console.WriteLine("La cantidad estuvo en los limites permitidos");
                }
            }

            Console.WriteLine($"\nEL promedio de la jornada fue {promedioPesca.ToString("0.00")} kgs");
            if (promedioPesca > 200)
                Console.WriteLine("Pesca excesiva, ¡se debe ejercer control más estricto!");
            else
                Console.WriteLine("Jornada de Pesca exitosa");

        }

        /// <summary>
        /// Obtiene el promedio de pesca de la jornada
        /// </summary>
        /// <param name="matrizCantidades">Contiene la pesca por método</param>
        /// <returns></returns>
        static float ObtienePromedioPesca(float[,] matrizCantidades)
        {
            float promedio = 0;

            for (int i = 0; i < matrizCantidades.GetLength(0); i++)
                for (int j = 0; j < matrizCantidades.GetLength(1); j++)
                    promedio += matrizCantidades[i, j];

            promedio /= matrizCantidades.Length;

            return promedio;
        }
    }
}

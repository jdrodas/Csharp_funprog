using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PescaArtesanalOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Programa para el control de la pesca artesanal - Orientado a Objetos ***");

            string[] nombresEspecie = { "Sabaleta", "Tilapia", "Trucha", "Mojarra", "Cachama" };
            string[] nombresMetodos = { "Atarraya", "Chinchorro", "Arpón", "Red de Arrastre", "Manual" };

            Console.WriteLine("\nLas especies permitidas son:");
            foreach (string especiePescado in nombresEspecie)
                Console.WriteLine($" - {especiePescado}");

            Console.WriteLine("\nLos métodos de pesca auorizados son:");
            foreach (string metodoPesca in nombresMetodos)
                Console.WriteLine($" - {metodoPesca}");

            //Aqui declaramos un arreglo de Objetos tipo pesca
            int pescasTotales = nombresEspecie.Length * nombresMetodos.Length;

            Pesca[] LasPescas = new Pesca[pescasTotales];

            //Aqui inicializamos todo el arreglo invocando el constructor para cada elemento
            for (int i = 0; i < LasPescas.Length; i++)
                LasPescas[i] = new Pesca();


            //Aqui recorremos las combinaciones de especies con métodos para leer la cantidad
            int contadorEspecies = 0;
            int contadorMetodos;
            int contadorPescas = 0;

            do
            {
                contadorMetodos = 0;
                while (contadorMetodos < nombresMetodos.Length)
                {
                    try
                    {
                        Console.Write($"\nPesca para {nombresEspecie[contadorEspecies]} con {nombresMetodos[contadorMetodos]}: ");
                        LasPescas[contadorPescas].Cantidad = float.Parse(Console.ReadLine());
                        LasPescas[contadorPescas].Metodo = nombresMetodos[contadorMetodos];
                        LasPescas[contadorPescas].Especie = nombresEspecie[contadorEspecies];

                        if (LasPescas[contadorPescas].Cantidad >= 0)
                        {
                            contadorPescas++;
                            contadorMetodos++;
                        }
                        else
                            Console.WriteLine("El dato númerico no representa una cantidad. Intenta nuevamente!");
                    }
                    catch (FormatException elError)
                    {
                        Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                        Console.WriteLine(elError.Message);
                    }
                }

                //Aqui pasamos a la siguiente especie
                contadorEspecies++;
            }
            while (contadorEspecies < nombresEspecie.Length);
            //Aqui calculamos el promedio de pesca de la jornada
            float promedioPesca = ObtienePromedioPesca(LasPescas);

            //Visualizamos los resultados 
            Console.WriteLine("\n\n *** Resultados de la jornada de pesca ***");
            foreach (Pesca unaPesca in LasPescas)
            {
                Console.WriteLine($"\nEspecie {unaPesca.Especie}, Método {unaPesca.Metodo}" +
                $" se pescó {unaPesca.Cantidad} kgs");

                if (unaPesca.Cantidad > 200)
                    Console.WriteLine("Se superó el tope máximo!");
                else
                    Console.WriteLine("La cantidad estuvo en los limites permitidos");                        
            }

            Console.WriteLine($"\nEL promedio de la jornada fue {promedioPesca.ToString("0.00")} kgs");
            if (promedioPesca > 200)
                Console.WriteLine("Pesca excesiva, ¡se debe ejercer control más estricto!");
            else
                Console.WriteLine("Jornada de Pesca exitosa");

            //Aqui calculamos el total de la pesca manual
            float[] totalPescaManual = ObtieneTotalPescaManual(LasPescas, nombresEspecie);

            //Aqui visualizamos los resultados de la pesca manual
            Console.WriteLine("\n *** Resultados de la Pesca Manual ***");
            for (int i = 0; i < nombresEspecie.Length; i++)
            {
                Console.WriteLine($"Especie: {nombresEspecie[i]}, cantidad: {totalPescaManual[i]}");
            }

            //Aqui Obtenemos la pesca máxima
            Pesca pescaMaxima = new Pesca();
            ObtienePescaMaxima(LasPescas, out pescaMaxima);

            Console.WriteLine($"\n\nLa pesca máxima fue de la especie {pescaMaxima.Especie} " +
                $"con el método {pescaMaxima.Metodo} con una cantidad de {pescaMaxima.Cantidad} kg");
        }

        static void ObtienePescaMaxima(Pesca[] arregloPesca, out Pesca pescaMaxima)
        {
            //Arbitrariamente definimos que el primer elemento del arreglo es el máximo
            pescaMaxima = arregloPesca[0];
            
            for (int i = 0; i < arregloPesca.Length; i++)
            {
                //Si es mayor la cantidad de la siguiente posición, esa es la nueva pesca máxima
                if (arregloPesca[i].Cantidad > pescaMaxima.Cantidad)
                    pescaMaxima = arregloPesca[i];
            }
        }

        /// <summary>
        /// Obtiene el Total de pescados obtenidos de manera manual por especie
        /// </summary>
        /// <param name="arregloPesca">El arreglo con las pescas</param>
        /// <param name="arregloEspecies">El arreglo con las especies</param>
        /// <returns>la cantidad de pescados por especie</returns>
        static float[] ObtieneTotalPescaManual(Pesca[] arregloPesca, string[] arregloEspecies)
        {
            float[] totalPescaEspecie = new float[arregloEspecies.Length];

            for (int i = 0; i < arregloEspecies.Length; i++)
            {
                for (int j = 0; j < arregloPesca.Length; j++)
                {
                    if (arregloPesca[j].Metodo == "Manual" && arregloPesca[j].Especie == arregloEspecies[i])
                    {
                        totalPescaEspecie[i] += arregloPesca[j].Cantidad;
                    }
                }
            }

            return totalPescaEspecie;
        }

        /// <summary>
        /// Obtiene el promedio de todas las pescas realizadas
        /// </summary>
        /// <param name="arregloPesca">arreglo con todas las pescas</param>
        /// <returns>promedio calculado</returns>
        static float ObtienePromedioPesca(Pesca[] arregloPesca)
        {
            float promedio = 0;

            foreach (Pesca unaPesca in arregloPesca)
                promedio += unaPesca.Cantidad;

            promedio /= arregloPesca.Length;

            return promedio;
        }
    }
}

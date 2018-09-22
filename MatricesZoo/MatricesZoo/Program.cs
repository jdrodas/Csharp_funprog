/*
Programa:       MatricesZoo
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com


Propósito:
----------

En un zoológico se desea llevar control de la cantidad de alimentación
que se requiere por tipo de animal que se encuentra en las instalaciones.

Para efectos de simplificación, se tendrán animales herbívoros, carnívoros
en los entornos acuáticos, terrestres y aéreos.

Se desea construir un programa que lea la cantidad de alimento en kg por
cada combinación y al final se obtengan los totales por tipo de entorno
y tipo de alimentación.

la cantidad de alimento está en un rango entre 10 y 50 kg.

El programa debe implementar funciones que se llamen "ObtieneTotalesAlimentacion" 
y "ObtieneTotalesEntorno" que recibe como parametro la matriz con las cantidades 
de alimento y devuelve el tipo de total que se requiere (entorno o tipo).

Recomendaciones de mejora
-------------------------

-- Consolidar las funciones de ObtieneTotalesAlimentación y ObtieneTotalesEntorno
   en una sola función que reciba atributos adicionales para identificar el tipo
   de total requerido.
 
 */
using System;

namespace MatricesZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para totalizar la cantidad de comida que se necesita en un Zoológico");
            Console.WriteLine("Se tienen animales herbívoros y carnívoros en entornos");
            Console.WriteLine("Aéreos, terrestres y acuáticos.");
            Console.WriteLine("La cantidad de alimento está entre [10;50] kg.");
            Console.WriteLine("Se visualizan totales por entorno y por tipo de alimentación\n\n");

            string[] tipos = { "Herbívoros", "Carnívoros" };
            string[] entornos = { "Acuático", "Terrestre", "Aéreo" };

            float[,] alimentos = new float[entornos.Length, tipos.Length];

            int totalTipos = 0, totalEntornos = 0;
            float cantidad;

            //Captura de información e ingreso en la matriz
            while (totalEntornos < entornos.Length)
            {
                //Para recorrer todos los tipos de este entorno
                totalTipos = 0;

                while (totalTipos < tipos.Length)
                {
                    try
                    {
                        Console.Write("Ingresa la cantidad de alimentos para {0} en el entorno {1}: ",
                            tipos[totalTipos],
                            entornos[totalEntornos]);
                        cantidad = float.Parse(Console.ReadLine());

                        //verificamos que la cantidad esté en el rango [10;50]
                        if (cantidad >= 10 && cantidad <= 50)
                        {
                            alimentos[totalEntornos, totalTipos] = cantidad;
                            totalTipos++;
                        }
                        else
                            Console.WriteLine("La cantidad de alimento ingresada no está en el rango [10;50]. Intenta nuevamente! \n");

                    }
                    catch (FormatException error )
                    {
                        Console.WriteLine("Ingresaste un dato no numérico, intenta nuevamente!");
                        Console.WriteLine("Error: {0} \n", error.Message);
                    }
                }

                //Terminamos los tipos, Incrementamos para el siguiente entorno
                totalEntornos++;
            }

            //aqui calculamos los totales solicitados
            float TotalCantidad = 0;

            for (totalEntornos = 0; totalEntornos < entornos.Length; totalEntornos++)
            { 
                for (totalTipos = 0; totalTipos < tipos.Length; totalTipos++)
                { 
                    TotalCantidad += alimentos[totalEntornos, totalTipos];
                }
            }

            //Arreglos que tienen los totales por filas (entornos) y columnas (tipos)
            float[] CantidadTotalAlimentacion = ObtieneTotalAlimentacion(alimentos);
            float[] CantidadTotalEntorno = ObtieneTotalEntorno(alimentos);

            //aqui visualizamos los resultados
            Console.WriteLine("\n\nLos resultados obtenidos son:");
            Console.WriteLine("Total Kgs de alimento en todo el zoológico: {0}", TotalCantidad);

            Console.WriteLine("\nTotal kgs de alimento por tipo de alimentación:");

            for (int i = 0; i < tipos.Length; i++)
                Console.WriteLine("Tipo {0} se consume {1}",
                    tipos[i], CantidadTotalAlimentacion[i]);
            
            Console.WriteLine("\nTotal kgs de alimento por entorno:");

            for (int i = 0; i < entornos.Length; i++)
                Console.WriteLine("Tipo {0} se consume {1}",
                    entornos[i], CantidadTotalEntorno[i]);
            
        }

        /// <summary>
        /// Función que obtiene el total de alimentos por tipo del animal
        /// </summary>
        /// <param name="matrizAlimentos">Matriz con las cantidades de alimento</param>
        /// <returns>el arreglo con los totales por cada tipo</returns>
        static float[] ObtieneTotalAlimentacion(float[,] matrizAlimentos)
        {
            float[] resultado = new float[2]; //Dos tipos de alimentación

            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //aqui recorremos la matriz, totalizando solo por tipo de alimentos
            for (int entorno = 0; entorno <3; entorno++)
            {
                for (int tipo = 0; tipo < 2; tipo++)
                {
                    //totalizará solamente lo del mismo tipo
                    resultado[tipo] += matrizAlimentos[entorno, tipo];
                }
            }

            return resultado;
        }

        /// <summary>
        /// Función que obtiene el total de alimentos por entorno del animal
        /// </summary>
        /// <param name="matrizAlimentos">Matriz con las cantidades de alimento</param>
        /// <returns>el arreglo con los totales por cada entorno</returns>
        static float[] ObtieneTotalEntorno(float[,] matrizAlimentos)
        {
            float[] resultado = new float[3]; //Tres entornos

            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //aqui recorremos la matriz, totalizando solo por tipo de entorno
            for (int entorno = 0; entorno < 3; entorno++)
            {
                for (int tipo = 0; tipo < 2; tipo++)
                {
                    //totalizará solamente lo del mismo tipo
                    resultado[entorno] += matrizAlimentos[entorno, tipo];
                }
            }
            return resultado;
        }
    }
}

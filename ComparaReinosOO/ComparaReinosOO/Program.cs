/*
Programa:       ComparaReinos
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Problema Propuesto:
-------------------
Hay 3 Reyes discutiendo cual de todos tiene el reino mas grande Nidas, Saladino y la reina Victoria.
Cada reino esta organizado por provincias, ducados y estados, ellos están de acuerdo con crear un 
sistema de puntuación que los ayude a juzgar cual es el mejor reino.
- El numero de estados se multiplica por 2 
- El numero de ducados se multiplica por 3
- El numero de provincias se multiplica por 6

Se busca:
- capturar por consola el numero de provincias, ducados y estados de cada rey
- calcular la puntuación del reino.
- Indicar si hay un reino mayor o se presenta algún empate en la puntuación

Mejora de la versión anterior:
- Implemente el objeto "Reino" y modifique la implementación para tomar provecho de esta aproximación
 
 */

using System;

namespace ComparaReinosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparando Reinos\n");

            Console.WriteLine("Hay 3 Reyes discutiendo cual de todos tiene el reino mas grande Nidas, Saladino y la reina Victoria.");
            Console.WriteLine("Cada reino esta organizado por provincias, ducados y estados, ellos están de acuerdo con crear un ");
            Console.WriteLine("sistema de puntuación que los ayude a juzgar cual es el mejor reino.\n");

            Console.WriteLine("- El numero de estados se multiplica por 2");
            Console.WriteLine("- El numero de ducados se multiplica por 3");
            Console.WriteLine("- El numero de provincias se multiplica por 6\n");

            //Declaramos un arreglo de reinos
            Reino[] losReinos = new Reino[3];

            //Inicializamos cada posición del arreglo con una instancia de la clase
            for (int i = 0; i < losReinos.Length; i++)
                losReinos[i] = new Reino();

            //Asignamos nombre de los reyes del reino
            losReinos[0].Rey = "Nidas";
            losReinos[1].Rey = "Saladino";
            losReinos[2].Rey = "Victoria";

            //Aqui leemos los datos de cada reino
            int elReino = 0;
            do
            {
                try
                {
                    Console.WriteLine($"\nInformación para el reino de {losReinos[elReino].Rey}:");
                    Console.Write("Cantidad de estados: ");
                    losReinos[elReino].Estados = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad de ducados: ");
                    losReinos[elReino].Ducados = int.Parse(Console.ReadLine());
                    Console.Write("Cantidad de provincias: ");
                    losReinos[elReino].Provincias = int.Parse(Console.ReadLine());

                    //Aqui validamos si las cantidades ingresadas sean cantidades positivas
                    if (losReinos[elReino].Estados>=0 && 
                        losReinos[elReino].Provincias >=0 &&
                        losReinos[elReino].Ducados >=0)
                    {
                        elReino++;
                    }
                    else
                    {
                        Console.WriteLine("Las cantidades para estados, provincias y ducados no deben ser" +
                            " cantidades negativas. Intenta nuevamente! \n");
                    }
                }
                catch (FormatException errorFormato)
                {
                    Console.WriteLine("Los datos de estados,ducados y provincias son numericos. intenta nuevamente");
                    Console.WriteLine($"Error: {errorFormato.Message}");
                }
            }
            while (elReino < losReinos.Length);

            //Aqui visualizamos la información del reino - utilizamos foreach
            Console.WriteLine("\n\nLos datos ingresados fueron;");

            //Aqui utilizamos el ciclo "foreach" para recorrer
            //CADA UNO de los reinos en el arreglo
            foreach (Reino laTierritaDeUnFulano in losReinos)
                Console.WriteLine(laTierritaDeUnFulano.ObtieneInfoReino());

            //Aqui identificamos quien tiene el mejor reino
            IdentificaMejorReino(losReinos);
        }

        /// <summary>
        /// Identifica cual es el mejor reino según los puntos
        /// </summary>
        /// <param name="arregloReinos">El arreglo de los reinos</param>
        static void IdentificaMejorReino(Reino[] arregloReinos)
        {
            //Arbitrariamente definimos el primero como el mejor
            Reino reinoSupremo = arregloReinos[0];

            //con un ciclo recorremos LOS DEMÁS para validar esa hipotesis
            for (int i = 1; i < arregloReinos.Length; i++)
                if (reinoSupremo.Puntos < arregloReinos[i].Puntos)
                    reinoSupremo = arregloReinos[i];

            Console.WriteLine($"\n\nEl reino supremo es el de {reinoSupremo.Rey} " +
                $"que tiene {reinoSupremo.Puntos} puntos!");
        }
    }
}
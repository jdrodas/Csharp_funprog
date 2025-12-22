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

 */


using System;

namespace ComparaReinos
{
    public class Program
    {
        static void Main()
        {

            Console.WriteLine("Comparando Reinos\n");

            Console.WriteLine("Hay 3 Reyes discutiendo cual de todos tiene el reino mas grande Nidas, Saladino y la reina Victoria.");
            Console.WriteLine("Cada reino esta organizado por provincias, ducados y estados, ellos están de acuerdo con crear un ");
            Console.WriteLine("sistema de puntuación que los ayude a juzgar cual es el mejor reino.\n");

            Console.WriteLine("- El numero de estados se multiplica por 2");
            Console.WriteLine("- El numero de ducados se multiplica por 3");
            Console.WriteLine("- El numero de provincias se multiplica por 6\n");

            /*
            
            Nota de JuanD:
            
            La versión increiblemente simplificada asume que todos los datos se ingresarán correctamente,
            es decir, números mayores que cero.
            
            En la vida real esto no pasa, por lo que es necesario establecer los controles necesarios para
            "blindar" el funcionamiento a pesar de posibles errores del usuario.
            
            Esta versión es la increiblemente simplificada. Una versión mejorada la encuentras en:
            https://github.com/jdrodas/Csharp_funprog/tree/master/ComparaReinosOO

            */

            //Declaramos las variables
            int nidasDucados, nidasEstados, nidasProvincias, nidasPuntos;
            int saladinoDucados, saladinoEstados, saladinoProvincias, saladinoPuntos;
            int victoriaDucados, victoriaEstados, victoriaProvincias, victoriaPuntos;


            //Leemos los datos para cada reino
            Console.WriteLine("\nInformación para el reino de Nidas:");
            Console.Write("Cantidad de estados: ");
            nidasEstados = int.Parse(Console.ReadLine()!);
            Console.Write("Cantidad de ducados: ");
            nidasDucados = int.Parse(Console.ReadLine()!);
            Console.Write("Cantidad de provincias: ");
            nidasProvincias = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\nInformación para el reino de Saladino:");
            Console.Write("Cantidad de estados: ");
            saladinoEstados = int.Parse(Console.ReadLine()!);
            Console.Write("Cantidad de ducados: ");
            saladinoDucados = int.Parse(Console.ReadLine()!);
            Console.Write("Cantidad de provincias: ");
            saladinoProvincias = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\nInformación para el reino de Victoria:");
            Console.Write("Cantidad de estados: ");
            victoriaEstados = int.Parse(Console.ReadLine()!);
            Console.Write("Cantidad de ducados: ");
            victoriaDucados = int.Parse(Console.ReadLine()!);
            Console.Write("Cantidad de provincias: ");
            victoriaProvincias = int.Parse(Console.ReadLine()!);

            //Calculamos la puntuación para cada reino
            nidasPuntos = (nidasEstados * 2) +
                            (nidasDucados * 3) +
                            (nidasProvincias * 6);

            saladinoPuntos = (saladinoEstados * 2) +
                            (saladinoDucados * 3) +
                            (saladinoProvincias * 6);

            victoriaPuntos = (victoriaEstados * 2) +
                            (victoriaDucados * 3) +
                            (victoriaProvincias * 6);

            //Visualizamos resultados por cada reino
            Console.WriteLine("\n\nInformación de cada reino:");

            Console.WriteLine($"Reino de Nidas: Puntaje {nidasPuntos}");
            Console.WriteLine($"\tEstados: {nidasEstados}, Ducados: {nidasDucados}, Provincias: {nidasProvincias}\n");

            Console.WriteLine($"Reino de Saladino: Puntaje {saladinoPuntos}");
            Console.WriteLine($"\tEstados: {saladinoEstados}, Ducados: {saladinoDucados}, Provincias: {saladinoProvincias}\n");

            Console.WriteLine($"Reino de Victoria: Puntaje {victoriaPuntos}");
            Console.WriteLine($"\tEstados: {victoriaEstados}, Ducados: {victoriaDucados}, Provincias: {victoriaProvincias}\n");

            //Aqui preguntamos cual es el reino mayor:

            bool mayorReinoEncontrado = false;

            //Si es Nidas
            if (nidasPuntos > saladinoPuntos && nidasPuntos > victoriaPuntos)
            {
                Console.WriteLine("El reino de Nidas es el de mayor puntuación");
                mayorReinoEncontrado = true;
            }

            //Si es Saladino
            if (saladinoPuntos > nidasPuntos && saladinoPuntos > victoriaPuntos)
            {
                Console.WriteLine("El reino de Saladino es el de mayor puntuación");
                mayorReinoEncontrado = true;
            }

            //Si es Victoria
            if (victoriaPuntos > saladinoPuntos && victoriaPuntos > nidasPuntos)
            {
                Console.WriteLine("El reino de Victoria es el de mayor puntuación");
                mayorReinoEncontrado = true;
            }

            //Si no se encontró un único reino mayor que los demás:
            if (mayorReinoEncontrado == false)
                Console.WriteLine("No se encontró un reino único que sea mayor que los demás");
        }
    }
}
